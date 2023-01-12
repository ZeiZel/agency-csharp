using Microsoft.Data.SqlClient;

namespace agency_csharp
{
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    enum SwitchState
    {
        Employee,
        Client,
        Organization,
        Vacancy,
        Contract,
        Response
    }

    public partial class MainWindow : Form
    {
        private readonly CheckUser _user;
        Database database = new Database();

        readonly string refreshQueryEmp =
            "select id_pk_user, u_name, u_surname, u_patronymic, u_phoneNumber from Users inner join Employee E on Users.id_pk_user = E.id_fk_user;";
        readonly string refreshQueryClient =
            "select id_pk_user, u_name, u_surname, u_patronymic, u_phoneNumber from Users inner join Client C on Users.id_pk_user = C.id_user;";
        readonly string refreshQueryOrg =
            "select id_pk_organization, o_name, r_login, o_phoneNumber, o_email from Organization inner join Client C on C.id_pk_client = Organization.id_fk_client inner join Users U on U.id_pk_user = C.id_user inner join Register R2 on U.id_pk_user = R2.id_fk_user";
        readonly string refreshQueryVac =
            "select id_pk_vacancy, o_name, v_profession, v_description, o_phoneNumber from Vacancy inner join Organization O on O.id_pk_organization = Vacancy.id_organization";
        readonly string refreshQueryContracts =
            "select id_pk_contract, c_conditions, c_createdAt, E.u_name, E.u_surname, C.u_name, C.u_surname from Contracts inner join Employee Emp on Contracts.c_fk_employee = Emp.id_pk_employee inner join Client Cli on Cli.id_pk_client = Contracts.c_fk_client inner join Users C on C.id_pk_user = Cli.id_user inner join Users E on E.id_pk_user = Emp.id_fk_user";
        readonly string refreshQueryResp =
            "select id_pk_response, o_name, v_profession, u_name, u_surname, u_patronymic, u_phoneNumber from UserResponse inner join Vacancy V on V.id_pk_vacancy = UserResponse.id_fk_vacancy inner join Organization O on O.id_pk_organization = V.id_organization inner join Users U on U.id_pk_user = UserResponse.id_fk_user";

        int selectedRow;

        public MainWindow(CheckUser user)
        {
            _user = user;

            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            #region Вызов функций отрисовки таблиц

            string[] columnsEmp = { "id_pk_user", "u_name", "u_surname", "u_patronymic", "u_phoneNumber" };
            string[] columnNamesEmp = { "Идентификатор", "Имя", "Фамилия", "Отчество", "Номер телефона" };
            Utilities.CreateColumns(dataGridView1, columnsEmp, columnNamesEmp);
            Utilities.RefreshDataGrid(dataGridView1, database, SwitchState.Employee, refreshQueryEmp);
            dataGridView1.Columns[5].Visible = false;

            string[] columnsClients = { "id_pk_user", "u_name", "u_surname", "u_patronymic", "u_phoneNumber" };
            string[] columnNamesClients = { "ID_клиента", "Имя", "Фамилия", "Отчество", "Номер телефона" };
            Utilities.CreateColumns(clientView_dgv, columnsClients, columnNamesClients);
            Utilities.RefreshDataGrid(clientView_dgv, database, SwitchState.Client, refreshQueryClient);
            clientView_dgv.Columns[5].Visible = false;

            string[] columnsOrg = { "id_pk_organization", "o_name", "id_fk_client", "o_phoneNumber", "o_email" };
            string[] columnNamesOrg = { "Идентификатор", "Наименование", "Представитель", "Контактный номер", "Почта" };
            Utilities.CreateColumns(organization_dgv, columnsOrg, columnNamesOrg);
            Utilities.RefreshDataGrid(organization_dgv, database, SwitchState.Organization, refreshQueryOrg);
            organization_dgv.Columns[5].Visible = false;

            string[] columnsVac = { "id_pk_vacancy", "o_name", "v_profession", "v_description", "o_phoneNumber" };
            string[] columnNamesVac = { "ID вакансии", "Организация", "Должность", "Описание", "Контакный номер" };
            Utilities.CreateColumns(vacancy_dgv, columnsVac, columnNamesVac);
            Utilities.RefreshDataGrid(vacancy_dgv, database, SwitchState.Vacancy, refreshQueryVac);
            vacancy_dgv.Columns[5].Visible = false;

            string[] columnsContracts = { "id_pk_contract", "c_conditions", "c_createdAt", "u_name", "u_surname", "u_name", "u_surname" };
            string[] columnNamesContracts = { "ID контракта", "Условия", "Дата заключения", "Имя агента", "Фамилия агента", "Имя клиента", "Фамилия клиента" };
            Utilities.CreateColumns(contract_dgv, columnsContracts, columnNamesContracts);
            Utilities.RefreshDataGrid(contract_dgv, database, SwitchState.Contract, refreshQueryContracts);
            contract_dgv.Columns[7].Visible = false;

            string[] columnsResp = { "id_pk_response", "o_name", "v_profession", "u_name", "u_surname", "u_patronymic", "u_phoneNumber" };
            string[] columnNamesResp = { "ID отклика", "Организация", "Должность", "Имя", "Фамилия", "Отчество", "Номер телефона" };
            Utilities.CreateColumns(response_dgv, columnsResp, columnNamesResp);
            Utilities.RefreshDataGrid(response_dgv, database, SwitchState.Response, refreshQueryResp);
            response_dgv.Columns[7].Visible = false;

            #endregion
        }

        // Определяет уровень доступа для админа
        private void IsAdmin()
        {
            управлениеToolStripMenuItem.Visible = _user.IsAdmin;
            файлToolStripMenuItem.Visible = _user.IsAdmin;

            add_btn.Enabled = _user.IsAdmin;
            delete_btn.Enabled = _user.IsAdmin;
            change_btn.Enabled = _user.IsAdmin;
            save_btn.Enabled = _user.IsAdmin;

            groupBox1.Visible = _user.IsAdmin;

            contractChange_btn.Visible = _user.IsAdmin;
            contractChange_pb.Visible = _user.IsAdmin;
        }

        /// <summary>
        /// Этот метод будет производить изменение данных
        /// </summary>
        /// <param name="state"></param>
        private void Change(SwitchState state)
        {
            int selectedRowIndex;

            int id;

            Int64 userNumber;

            string userName, userSurname, userPatronymic;

            string orgName, orgNumber, orgMail, orgClient;

            string profession, vacDescription, vacNumber;

            string contractDate,
                  contractConditions,
                  contractClientName,
                  contractClientSurname,
                  contractAgentName,
                  contractAgentSurname;

            string resProf, resOrg;

            switch (state)
            {
                case SwitchState.Employee:
                    selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

                    id = Convert.ToInt32(userId.Text);
                    userName = name_tb.Text;
                    userSurname = surname_tb.Text;
                    userPatronymic = thirdname_tb.Text;

                    if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        if (Int64.TryParse(number_tb.Text, out userNumber))
                        {
                            dataGridView1.Rows[selectedRowIndex].SetValues(id, userName, userSurname, userPatronymic, userNumber);
                            dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                        }
                        else
                        {
                            MessageBox.Show("Номер телефона введён неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    break;
                case SwitchState.Client:
                    selectedRowIndex = clientView_dgv.CurrentCell.RowIndex;

                    id = Convert.ToInt32(clientID_tb.Text);
                    userName = clientName_tb.Text;
                    userSurname = clientSur_tb.Text;
                    userPatronymic = clientPat_tb.Text;

                    if (clientView_dgv.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        if (Int64.TryParse(clientNum_tb.Text, out userNumber))
                        {
                            clientView_dgv.Rows[selectedRowIndex].SetValues(id, userName, userSurname, userPatronymic, userNumber);
                            clientView_dgv.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                        }
                        else
                        {
                            MessageBox.Show("Номер телефона введён неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    break;
                case SwitchState.Organization:
                    selectedRowIndex = organization_dgv.CurrentCell.RowIndex;

                    id = Convert.ToInt32(orgID_tb.Text);
                    orgName = orgName_tb.Text;
                    orgClient = orgClient_tb.Text;
                    orgNumber = orgNum_tb.Text;
                    orgMail = orgMail_tb.Text;

                    if (organization_dgv.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        organization_dgv.Rows[selectedRowIndex].SetValues(id, orgName, orgClient, orgNumber, orgMail);
                        organization_dgv.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                    }
                    break;
                case SwitchState.Vacancy:
                    selectedRowIndex = vacancy_dgv.CurrentCell.RowIndex;

                    id = Convert.ToInt32(vacancyID_tb.Text);
                    orgName = vacOrgName_tb.Text;
                    profession = vacName_tb.Text;
                    vacDescription = vacDecription_rtb.Text;
                    vacNumber = vacNum_tb.Text;

                    if (vacancy_dgv.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        if (Int64.TryParse(vacNum_tb.Text, out userNumber))
                        {
                            vacancy_dgv.Rows[selectedRowIndex].SetValues(id, orgName, profession, vacDescription, vacNumber);
                            vacancy_dgv.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                        }
                        else
                        {
                            MessageBox.Show("Номер телефона введён неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    break;
                case SwitchState.Contract:
                    selectedRowIndex = contract_dgv.CurrentCell.RowIndex;

                    id = Convert.ToInt32(contractId_tb.Text);
                    contractDate = contractDate_tb.Text;
                    contractConditions = contractDate_tb.Text;
                    contractClientName = contractClientName_tb.Text;
                    contractClientSurname = contractClientSurname_tb.Text;
                    contractAgentName = contractAgentName_tb.Text;
                    contractAgentSurname = contractAgentSurame_tb.Text;

                    if (contract_dgv.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        contract_dgv.Rows[selectedRowIndex].SetValues(id, contractConditions, contractDate, contractAgentName, contractAgentSurname, contractClientName, contractClientSurname);
                        contract_dgv.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                    }
                    break;
                case SwitchState.Response:
                    selectedRowIndex = response_dgv.CurrentCell.RowIndex;

                    id = Convert.ToInt32(responseId_tb.Text);
                    resOrg = responseOrg_tb.Text;
                    resProf = responseVac_tb.Text;
                    userName = responseClientName_tb.Text;
                    userSurname = responseClientSurname_tb.Text;
                    userPatronymic = responseClientPat_tb.Text;

                    if (response_dgv.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
                    {
                        if (Int64.TryParse(responseClientNum_tb.Text, out userNumber))
                        {
                            response_dgv.Rows[selectedRowIndex].SetValues(id, resOrg, resProf, userName, userSurname, userPatronymic, userNumber);
                            response_dgv.Rows[selectedRowIndex].Cells[7].Value = RowState.Modified;
                        }
                        else
                        {
                            MessageBox.Show("Номер телефона введён неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Произошла ошибка при изменении вызове функции изменения данных.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ClearFields(SwitchState state)
        {
            switch (state)
            {
                case SwitchState.Employee:
                    userId.Text = "";
                    name_tb.Text = "";
                    surname_tb.Text = "";
                    thirdname_tb.Text = "";
                    number_tb.Text = "";
                    break;
                case SwitchState.Client:
                    clientID_tb.Text = "";
                    clientName_tb.Text = "";
                    clientSur_tb.Text = "";
                    clientPat_tb.Text = "";
                    clientNum_tb.Text = "";
                    break;
                case SwitchState.Organization:
                    orgID_tb.Text = "";
                    orgMail_tb.Text = "";
                    orgName_tb.Text = "";
                    orgNum_tb.Text = "";
                    orgClient_tb.Text = "";
                    break;
                case SwitchState.Vacancy:
                    vacancyID_tb.Text = "";
                    vacName_tb.Text = "";
                    vacNum_tb.Text = "";
                    vacOrgName_tb.Text = "";
                    vacDecription_rtb.Text = "";
                    break;
                case SwitchState.Contract:
                    contractId_tb.Text = "";
                    contractDate_tb.Text = "";
                    contractConditions_tb.Text = "";
                    contractAgentName_tb.Text = "";
                    contractAgentSurame_tb.Text = "";
                    contractClientName_tb.Text = "";
                    contractClientSurname_tb.Text = "";
                    break;
                case SwitchState.Response:
                    responseClientName_tb.Text = "";
                    responseClientNum_tb.Text = "";
                    responseClientPat_tb.Text = "";
                    responseClientSurname_tb.Text = "";
                    responseId_tb.Text = "";
                    responseOrg_tb.Text = "";
                    responseVac_tb.Text = "";
                    break;
                default:
                    MessageBox.Show("Ошибка очистки поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        // ------------------------------------------------------------------------------------------------

        private void MainWindow_Load(object sender, EventArgs e)
        {
            userStatus_tstb.Text = $"{_user.Login}: {_user.Status}";
            IsAdmin();
        }

        /// <summary>
        /// Ввод выбранной записи в датагриде внутрь текстбоксов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                userId.Text = row.Cells[0].Value.ToString();
                name_tb.Text = row.Cells[1].Value.ToString();
                surname_tb.Text = row.Cells[2].Value.ToString();
                thirdname_tb.Text = row.Cells[3].Value.ToString();
                number_tb.Text = row.Cells[4].Value.ToString();
            }
        }

        private void client_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = clientView_dgv.Rows[selectedRow];

                clientID_tb.Text = row.Cells[0].Value.ToString();
                clientName_tb.Text = row.Cells[1].Value.ToString();
                clientSur_tb.Text = row.Cells[2].Value.ToString();
                clientPat_tb.Text = row.Cells[3].Value.ToString();
                clientNum_tb.Text = row.Cells[4].Value.ToString();
            }
        }

        private void org_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = organization_dgv.Rows[selectedRow];

                orgID_tb.Text = row.Cells[0].Value.ToString();
                orgName_tb.Text = row.Cells[1].Value.ToString();
                orgClient_tb.Text = row.Cells[2].Value.ToString();
                orgNum_tb.Text = row.Cells[3].Value.ToString();
                orgMail_tb.Text = row.Cells[4].Value.ToString();
            }
        }

        private void vac_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = vacancy_dgv.Rows[selectedRow];

                vacancyID_tb.Text = row.Cells[0].Value.ToString();
                vacOrgName_tb.Text = row.Cells[1].Value.ToString();
                vacName_tb.Text = row.Cells[2].Value.ToString();
                vacDecription_rtb.Text = row.Cells[3].Value.ToString();
                vacNum_tb.Text = row.Cells[4].Value.ToString();
            }
        }

        private void contract_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = contract_dgv.Rows[selectedRow];

                contractId_tb.Text = row.Cells[0].Value.ToString();
                contractConditions_tb.Text = row.Cells[1].Value.ToString();
                contractDate_tb.Text = row.Cells[2].Value.ToString();
                contractAgentName_tb.Text = row.Cells[3].Value.ToString();
                contractAgentSurame_tb.Text = row.Cells[4].Value.ToString();
                contractClientName_tb.Text = row.Cells[5].Value.ToString();
                contractClientSurname_tb.Text = row.Cells[6].Value.ToString();
            }
        }

        private void resp_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = response_dgv.Rows[selectedRow];

                responseId_tb.Text = row.Cells[0].Value.ToString();
                responseOrg_tb.Text = row.Cells[1].Value.ToString();
                responseVac_tb.Text = row.Cells[2].Value.ToString();
                responseClientName_tb.Text = row.Cells[3].Value.ToString();
                responseClientSurname_tb.Text = row.Cells[4].Value.ToString();
                responseClientPat_tb.Text = row.Cells[5].Value.ToString();
                responseClientNum_tb.Text = row.Cells[6].Value.ToString();
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(dataGridView1, database, SwitchState.Employee, refreshQueryEmp);
            ClearFields(SwitchState.Employee);
        }

        /// <summary>
        /// Добавление нового работника во вкладке сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Либо зарегистрируйте нового пользователя, либо дайте зарегистрироваться работнику самому. После данной операции перейдите в меню \"Управление\" и откройте окно \"Администрирование\", где вы и сможете поменять статус пользователя.", "Как добавить работника?");
            Form admin = new AdminPanel();
            admin.Show();
        }

        /// <summary>
        /// Кнопка очистки данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields(SwitchState.Employee);
        }

        /// <summary>
        /// Рефреш датагрида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientRefresh_btn_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(clientView_dgv, database, SwitchState.Client, refreshQueryClient);
            ClearFields(SwitchState.Client);
        }

        private void orgRefresh_btn_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(organization_dgv, database, SwitchState.Organization, refreshQueryOrg);
            ClearFields(SwitchState.Organization);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(vacancy_dgv, database, SwitchState.Vacancy, refreshQueryVac);
            ClearFields(SwitchState.Vacancy);
        }

        /// <summary>
        /// Дальше идут кнопки поиска записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            Utilities.Search(
                dataGridView1,
                database,
                SwitchState.Employee,
                $"select * from [dbo].[Users] inner join Employee E on Users.id_pk_user = E.id_fk_user where concat([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) like '%{search_tb.Text}%'"
            );
        }

        private void clientSearch_tb_TextChanged(object sender, EventArgs e)
        {
            Utilities.Search(
                clientView_dgv,
                database,
                SwitchState.Client,
                $"select * from [dbo].[Users] inner join Employee E on Users.id_pk_user = E.id_fk_user where concat([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) like '%{clientSearch_tb.Text}%'"
            );
        }

        private void orgSearch_tb_TextChanged(object sender, EventArgs e)
        {
            Utilities.Search(
                organization_dgv,
                database,
                SwitchState.Organization,
                $"select id_pk_organization, o_name, o_phoneNumber, o_email from Organization where concat(id_pk_organization, o_name, o_phoneNumber, o_email) like '%{orgSearch_tb.Text}%';"
            );
        }

        private void vacSearch_tb_TextChanged(object sender, EventArgs e)
        {
            Utilities.Search(
                vacancy_dgv,
                database,
                SwitchState.Vacancy,
                $"select id_pk_vacancy, o_name, v_profession, o_phoneNumber from Vacancy inner join Organization O on O.id_pk_organization = Vacancy.id_organization where concat(id_pk_vacancy, o_name, v_profession, o_phoneNumber) like '%{vacSearch_tb.Text}%';"
            );
        }

        /// <summary>
        /// Дальше идут кнопки удаления записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, EventArgs e)
        {
            // тут мы помечаем под удаление ячейку и после сохранения все изменения вступят в силу
            Utilities.DeleteRow(dataGridView1);
        }

        private void orgDel_btn_Click(object sender, EventArgs e)
        {
            Utilities.DeleteRow(organization_dgv);
        }

        private void vacDel_tb_Click(object sender, EventArgs e)
        {
            Utilities.DeleteRow(vacancy_dgv);
        }

        /// <summary>
        /// Дальше пойдут кнопки редактирования данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_btn_Click(object sender, EventArgs e)
        {
            Change(SwitchState.Employee);
        }

        private void clientChange_Click(object sender, EventArgs e)
        {
            Change(SwitchState.Client);

        }

        private void orgChange_btn_Click(object sender, EventArgs e)
        {
            Change(SwitchState.Organization);

        }

        private void vacChange_tb_Click(object sender, EventArgs e)
        {
            Change(SwitchState.Vacancy);

        }

        /// <summary>
        /// Дапльше пойдёт кнопка сохранения данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_btn_Click(object sender, EventArgs e)
        {
            // чтобы работало удаление, нужно в сохранение запихнуть обновление
            UpdateDGV.Employees(dataGridView1, database);
        }

        private void clientSave_Click(object sender, EventArgs e)
        {
            UpdateDGV.Clients(clientView_dgv, database);
        }

        private void orgSave_btn_Click(object sender, EventArgs e)
        {
            UpdateDGV.Organizations(organization_dgv, database);
        }

        private void vacSave_tb_Click(object sender, EventArgs e)
        {
            UpdateDGV.Vacancys(vacancy_dgv, database);
        }

        private void администрированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form admin = new AdminPanel();
            admin.Show();
        }

        private void отчётностьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form report = new Report();
            report.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
        }

        private void обновленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form updates = new CheckUpdates();
            updates.Show();
        }

        // TODO: Реализовать добавление клиента
        /// <summary>
        /// Кнопки добавления записей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientAdd_Click(object sender, EventArgs e)
        {
            Form addClient = new ClientAdd();
            addClient.Show();
        }

        // TODO: Реализовать добавление организации
        private void orgAdd_btn_Click(object sender, EventArgs e)
        {
            Form addOrg = new AddOrganization();
            addOrg.Show();
        }

        private void vacAdd_tb_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var vacOrg = vacOrgName_tb.Text;
            var vacProf = vacName_tb.Text;
            var vacDesc = vacDecription_rtb.Text;
            var vacNumber = vacNum_tb.Text;

            if (Int64.TryParse(vacNumber, out Int64 n))
            {
                string queryString =
                    $"EXEC AddVacancy '{vacOrg}', '{vacProf}', '{vacDesc}', '{vacNumber}';";
                SqlCommand command = new SqlCommand(queryString, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Пожалуйста, введите корректный номер телефона",
                    "Не удалось добавить запись",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            database.closeConnection();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Form registerNewUser = new EmployeeRegister();
            registerNewUser.Show();
        }

        private void search_grid_btn_Click(object sender, EventArgs e)
        {
            Utilities.Search(
                dataGridView1,
                database,
                SwitchState.Employee,
                $"select * from [dbo].[Users] inner join Employee E on Users.id_pk_user = E.id_fk_user where concat([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) like '%{search_tb.Text}%'"
            );
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form login = new Login();
            login.Show();
        }

        private void passportEdit_btn_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("При переходе на данную форму вы обязуетесь не разглашать паспортные данные пользователей.",
                "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                ) == DialogResult.Yes)
            {
                if (
                        clientName_tb.Text.Length > 0 && clientName_tb.Text.Length <= 50 &&
                        clientSur_tb.Text.Length > 0 && clientSur_tb.Text.Length <= 50 &&
                        clientPat_tb.Text.Length > 0 && clientPat_tb.Text.Length <= 50
                    )
                {
                    Form documents = new Documents(clientName_tb.Text, clientSur_tb.Text, clientPat_tb.Text, clientID_tb.Text);
                    documents.Show();
                }
                else
                {
                    MessageBox.Show(
                        "Сначала выберите пользователя, у которого хотите отредактировать паспорт",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        // TODO: Реализовать добавление контракта
        private void contractAdd_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            //var id = Convert.ToInt32(userId_tb.Text);
            var userName = name_tb.Text;
            var userSurname = surname_tb.Text;
            var userPatronymic = thirdname_tb.Text;
            var userNumber = number_tb.Text;

            if (Int64.TryParse(userNumber, out Int64 n))
            {
                string queryString =
                    $"insert into [dbo].[Users] ([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) values('{userName}', '{userSurname}', '{userPatronymic}', '{userNumber}');";
                SqlCommand command = new SqlCommand(queryString, database.getConnection());
                command.ExecuteNonQuery();

                string queryAddEmployee = $"EXEC AddUserEmployee  {userName}, {userNumber}";
                SqlCommand commandAddEmp = new SqlCommand(queryAddEmployee, database.getConnection());
                commandAddEmp.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Пожалуйста, введите корректный номер телефона",
                    "Не удалось добавить запись",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            database.closeConnection();
        }

        private void contractSave_btn_Click(object sender, EventArgs e)
        {
            UpdateDGV.Contracts(contract_dgv, database);
        }

        private void responseSave_btn_Click(object sender, EventArgs e)
        {
            UpdateDGV.Responses(response_dgv, database);
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.Show();
        }

        private void contractSearch_tb_TextChanged(object sender, EventArgs e)
        {
            Utilities.Search(
                contract_dgv,
                database,
                SwitchState.Vacancy,
                $"select id_pk_contract, c_conditions, c_createdAt, E.u_name, E.u_surname, C.u_name, C.u_surname from Contracts inner join Employee Emp on Contracts.c_fk_employee = Emp.id_pk_employee inner join Client Cli on Cli.id_pk_client = Contracts.c_fk_client inner join Users C on C.id_pk_user = Cli.id_user inner join Users E on E.id_pk_user = Emp.id_fk_user where concat(id_pk_contract, c_conditions, c_createdAt, E.u_name, E.u_surname, C.u_name, C.u_surname) like '%{contractSearch_tb.Text}%';"
            );
        }

        private void responseSearch_tb_TextChanged(object sender, EventArgs e)
        {
            Utilities.Search(
                response_dgv,
                database,
                SwitchState.Vacancy,
                $"select id_pk_response, o_name, v_profession, u_name, u_surname, u_patronymic, u_phoneNumber from UserResponse inner join Vacancy V on V.id_pk_vacancy = UserResponse.id_fk_vacancy inner join Organization O on O.id_pk_organization = V.id_organization inner join Users U on U.id_pk_user = UserResponse.id_fk_user where concat(id_pk_response, o_name, v_profession, u_name, u_surname, u_patronymic, u_phoneNumber) like '%{responseSearch_tb.Text}%';"
            );
        }

        private void responseSearch_btn_Click(object sender, EventArgs e)
        {
            Utilities.Search(
                response_dgv,
                database,
                SwitchState.Vacancy,
                $"select id_pk_response, o_name, v_profession, u_name, u_surname, u_patronymic, u_phoneNumber from UserResponse inner join Vacancy V on V.id_pk_vacancy = UserResponse.id_fk_vacancy inner join Organization O on O.id_pk_organization = V.id_organization inner join Users U on U.id_pk_user = UserResponse.id_fk_user where concat(id_pk_response, o_name, v_profession, u_name, u_surname, u_patronymic, u_phoneNumber) like '%{responseSearch_tb.Text}%';"
            );
        }

        private void contractSearch_btn_Click(object sender, EventArgs e)
        {
            Utilities.Search(
                contract_dgv,
                database,
                SwitchState.Vacancy,
                $"select id_pk_contract, c_conditions, c_createdAt, E.u_name, E.u_surname, C.u_name, C.u_surname from Contracts inner join Employee Emp on Contracts.c_fk_employee = Emp.id_pk_employee inner join Client Cli on Cli.id_pk_client = Contracts.c_fk_client inner join Users C on C.id_pk_user = Cli.id_user inner join Users E on E.id_pk_user = Emp.id_fk_user where concat(id_pk_contract, c_conditions, c_createdAt) like '%{contractSearch_tb.Text}%';"
            );
        }

        private void vacSearch_btn_Click(object sender, EventArgs e)
        {
            Utilities.Search(
                vacancy_dgv,
                database,
                SwitchState.Vacancy,
                $"select id_pk_vacancy, o_name, v_profession, o_phoneNumber from Vacancy inner join Organization O on O.id_pk_organization = Vacancy.id_organization where concat(id_pk_vacancy, o_name, v_profession, o_phoneNumber) like '%{vacSearch_tb.Text}%';"
            );
        }

        private void orgSearch_btn_Click(object sender, EventArgs e)
        {
            Utilities.Search(
                organization_dgv,
                database,
                SwitchState.Organization,
                $"select id_pk_organization, o_name, o_phoneNumber, o_email from Organization where concat(id_pk_organization, o_name, o_phoneNumber, o_email) like '%{orgSearch_tb.Text}%';"
            );
        }

        private void clientSearch_btn_Click(object sender, EventArgs e)
        {
            Utilities.Search(
                clientView_dgv,
                database,
                SwitchState.Client,
                $"select * from [dbo].[Users] inner join Employee E on Users.id_pk_user = E.id_fk_user where concat([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) like '%{clientSearch_tb.Text}%'"
            );
        }

        private void contractRefresh_btn_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(contract_dgv, database, SwitchState.Contract, refreshQueryContracts);
            ClearFields(SwitchState.Contract);
        }

        private void responseRefresh_brn_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(response_dgv, database, SwitchState.Response, refreshQueryResp);
            ClearFields(SwitchState.Response);
        }

        private void responseClear_btn_Click(object sender, EventArgs e)
        {
            ClearFields(SwitchState.Response);
        }

        private void contractClear_btn_Click(object sender, EventArgs e)
        {
            ClearFields(SwitchState.Contract);
        }

        private void vacClrear_btn_Click(object sender, EventArgs e)
        {
            ClearFields(SwitchState.Vacancy);
        }

        private void orgClear_btn_Click(object sender, EventArgs e)
        {
            ClearFields(SwitchState.Organization);
        }

        private void clientClear_btn_Click(object sender, EventArgs e)
        {
            ClearFields(SwitchState.Client);
        }

        private void responseDel_btn_Click(object sender, EventArgs e)
        {
            Utilities.DeleteRow(response_dgv);
        }

        private void contractChange_btn_Click(object sender, EventArgs e)
        {
            Change(SwitchState.Contract);

        }

        private void responseChange_btn_Click(object sender, EventArgs e)
        {
            Change(SwitchState.Response);

        }
    }
}
