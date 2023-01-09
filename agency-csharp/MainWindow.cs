using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
            "select id_pk_organization, o_name, o_phoneNumber, o_email from Organization;";
        readonly string refreshQueryVac = 
            "select id_pk_vacancy, o_name, v_profession, o_phoneNumber from Vacancy inner join Organization O on O.id_pk_organization = Vacancy.id_organization";
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

            // TODO: тут нужно поменять колонки таблиц
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

            string[] columnsOrg = { "id_pk_organization", "o_name", "o_phoneNumber", "o_email" };
            string[] columnNamesOrg = { "Идентификатор", "Наименование", "Контактный номер", "Почта" };
            Utilities.CreateColumns(organization_dgv, columnsOrg, columnNamesOrg);
            Utilities.RefreshDataGrid(organization_dgv, database, SwitchState.Organization, refreshQueryOrg);
            organization_dgv.Columns[4].Visible = false;

            string[] columnsVac = { "id_pk_vacancy", "o_name", "v_profession", "o_phoneNumber" };
            string[] columnNamesVac = { "ID вакансии", "Организация", "Должность", "Контакный номер" };
            Utilities.CreateColumns(vacancy_dgv, columnsVac, columnNamesVac);
            Utilities.RefreshDataGrid(vacancy_dgv, database, SwitchState.Vacancy, refreshQueryVac);
            vacancy_dgv.Columns[4].Visible = false;

            string[] columnsContracts = { "id_pk_contract", "c_conditions", "c_createdAt", "u_name", "u_surname", "u_name", "u_surname" };
            string[] columnNamesContracts = { "ID контракта", "Условия", "Дата заключения", "Имя клиента", "Фамилия клиента", "Имя агента", "Фамилия агента" };
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

        // Этот метод будет производить изменение данных
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = userId.Text;
            var userName = name_tb.Text;
            var userSurname = surname_tb.Text;
            var userPatronymic = thirdname_tb.Text;
            Int64 userNumber;

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
        }

        private void ClearFields()
        {
            userId.Text = "";
            name_tb.Text = "";
            surname_tb.Text = "";
            thirdname_tb.Text = "";
            number_tb.Text = "";
        }

        // ------------------------------------------------------------------------------------------------

        private void MainWindow_Load(object sender, EventArgs e)
        {
            userStatus_tstb.Text = $"{_user.Login}: {_user.Status}";
            IsAdmin();
        }

        // Ввод выбранной записи в датагриде внутрь текстбоксов
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

        // TODO: Нужно поменять тут колонки таблиц
        private void client_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
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

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = organization_dgv.Rows[selectedRow];

                orgID_tb.Text = row.Cells[0].Value.ToString();
                orgName_tb.Text = row.Cells[1].Value.ToString();
                orgNum_tb.Text = row.Cells[2].Value.ToString();
                orgMail_tb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void vac_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = vacancy_dgv.Rows[selectedRow];

                vacancyID_tb.Text = row.Cells[0].Value.ToString();
                vacOrgName_tb.Text = row.Cells[1].Value.ToString();
                vacName_tb.Text = row.Cells[2].Value.ToString();
                vacNum_tb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void contract_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
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

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
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
            ClearFields();
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
            ClearFields();
        }

        /// <summary>
        /// Рефреш датагрида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientRefresh_btn_Click(object sender, EventArgs e)
        {
            // TODO: Нужно поменять запрос на рефреш
            Utilities.RefreshDataGrid(clientView_dgv, database, SwitchState.Client, refreshQueryEmp);
        }

        private void orgRefresh_btn_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(organization_dgv, database, SwitchState.Organization, refreshQueryEmp);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Utilities.RefreshDataGrid(vacancy_dgv, database, SwitchState.Vacancy, refreshQueryEmp);
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

        private void clientDel_Click(object sender, EventArgs e)
        {

        }

        private void orgDel_btn_Click(object sender, EventArgs e)
        {

        }

        private void vacDel_tb_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Дальше пойдут кнопки редактирования данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_btn_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void clientChange_Click(object sender, EventArgs e)
        {

        }

        private void orgChange_btn_Click(object sender, EventArgs e)
        {

        }

        private void vacChange_tb_Click(object sender, EventArgs e)
        {

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

        private void orgAdd_btn_Click(object sender, EventArgs e)
        {
            Form addOrg = new AddOrganization();
            addOrg.Show();
        }

        private void vacAdd_tb_Click(object sender, EventArgs e)
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

        private void register_btn_Click(object sender, EventArgs e)
        {
            Form register = new Register();
            register.Show();
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
                } else
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

        private void contractAdd_btn_Click(object sender, EventArgs e)
        {

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
    }
}
