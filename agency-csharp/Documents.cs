using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agency_csharp
{
    public partial class Documents : Form
    {
        Database database = new Database();

        int selectedRow;

        private readonly string refreshQueryPassport = @"
        select
            id_pk_passport, id_pk_document, id_pk_adress, id_pk_client,
            p_name, p_surname, p_patronymic, p_number, p_series, p_birth, p_sex,
            d_TIN, d_education,
            a_region, a_city, a_street, a_building, a_apartment
        from UserDoc
            inner join Documents D on D.id_pk_document = UserDoc.id_fk_doc
            inner join Passport P on P.id_pk_passport = D.id_passport
            inner join Client C on P.id_adress = C.id_adress
            inner join Adress A on A.id_pk_adress = P.id_adress;
        ";

        public Documents()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            string[] columnsDoc = {
                "id_pk_passport", "id_pk_document", "id_pk_adress", "id_pk_client",
                "p_name", "p_surname", "p_patronymic", "p_number", "p_series", "p_birth", "p_sex",
                "d_TIN", "d_education",
                "a_region", "a_city", "a_street", "a_building", "a_apartment"
            };
            string[] columnNamesDoc = {
                "ID паспорта", "ID документа", "ID адреса", "ID клиента",
                "Имя", "Фамилия", "Отчество", "Номер паспорта", "Серия паспорта", "Дата рождения", "Пол",
                "ИНН", "Документ об образовании",
                "Регион", "Город", "Улица", "Дом", "Квартира"
            };
            CreateColumns(passport_dgv, columnsDoc, columnNamesDoc);
            RefreshDataGrid(passport_dgv, database, refreshQueryPassport);
            passport_dgv.Columns[18].Visible = false;
        }

        private void Documents_Load(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {
            if (
                MessageBox.Show(
                    "Вы уверены, что хотите очистить все эти данные? :3",
                    "Внимание",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                    ) == DialogResult.Yes
                )
            {
                passportId_tb.Text = "";
                passportNumber_tb.Text = "";
                passportSeries_tb.Text = "";
                passportSex_cb.Text = "";
                passportBirth_tb.Text = "";

                adressApartment_tb.Text = "";
                adressBuilding_tb.Text = "";
                adressCity_tb.Text = "";
                adressID_tb.Text = "";
                adressRegion_tb.Text = "";
                adressStreet_tb.Text = "";

                docsID_tb.Text = "";
                docsEducation_tb.Text = "";
                docsTIN_tb.Text = "";

                clientID_tb.Text = "";
                clientName_tb.Text = "";
                clientSur_tb.Text = "";
                clientPat_tb.Text = "";

                passportSearch_tb.Text = "";
            }
        }

        private void Update(DataGridView dgv, Database database)
        {
            database.openConnection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var rowState = (RowState)dgv.Rows[i].Cells[18].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Modified)
                {
                    var passID = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);
                    var passNum = dgv.Rows[i].Cells[7].Value.ToString();
                    var passSeries = dgv.Rows[i].Cells[8].Value.ToString();
                    var passBirth = dgv.Rows[i].Cells[9].Value.ToString();
                    var passSex = dgv.Rows[i].Cells[10].Value.ToString();

                    var adressID = Convert.ToInt32(dgv.Rows[i].Cells[2].Value);
                    var adressRegion = dgv.Rows[i].Cells[13].Value.ToString();
                    var adressCity = dgv.Rows[i].Cells[14].Value.ToString();
                    var adressStreet = dgv.Rows[i].Cells[15].Value.ToString();
                    var adressBuilding = dgv.Rows[i].Cells[16].Value.ToString();
                    var adressApartment = dgv.Rows[i].Cells[17].Value.ToString();

                    var docsID = Convert.ToInt32(dgv.Rows[i].Cells[1].Value);
                    var docsTIN = dgv.Rows[i].Cells[11].Value.ToString();
                    var docsEducation = dgv.Rows[i].Cells[12].Value.ToString();

                    var clientID = Convert.ToInt32(dgv.Rows[i].Cells[3].Value);
                    var clientName = dgv.Rows[i].Cells[4].Value.ToString();
                    var clientSur = dgv.Rows[i].Cells[5].Value.ToString();
                    var clientPat = dgv.Rows[i].Cells[6].Value.ToString();

                    string query = $"EXEC UpdateDocument " +
                        $"{passID}, {clientID}, {adressID}, {docsID},  " +
                        $"{passSeries}, {passNum}, '{passBirth}', '{passSex}'," +
                        $"'{adressRegion}', '{adressCity}', '{adressStreet}', '{adressBuilding}', '{adressApartment}', " +
                        $"'{docsTIN}', '{docsEducation}', '{clientName}', '{clientSur}', '{clientPat}';";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Документы пользователя изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            database.closeConnection();
        }

        private Boolean Checker(string query)
        {
            int length = GetLength(query);

            if (length > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private int GetLength(string query)
        {
            string queryString = query;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows.Count;
        }

        private void Change()
        {
            int selectedRowIndex = passport_dgv.CurrentCell.RowIndex;

            int passportID = Convert.ToInt32(passportId_tb.Text);
            int clientID = Convert.ToInt32(clientID_tb.Text);
            int adressID = Convert.ToInt32(adressID_tb.Text);
            int documentsID = Convert.ToInt32(docsID_tb.Text);

            int passSeries, passNum;
            var passBirth = passportBirth_tb.Text;
            var passSex = passportSex_cb.Text;

            var adressRegion = adressRegion_tb.Text;
            var adressCity = adressCity_tb.Text;
            var adressStreet = adressStreet_tb.Text;
            var adressBuilding = adressBuilding_tb.Text;
            var adressApartment = adressApartment_tb.Text;

            var docsTIN = docsTIN_tb.Text;
            var docsEducation = docsEducation_tb.Text;

            var clientName = clientName_tb.Text;
            var clientSur = clientSur_tb.Text;
            var clientPat = clientPat_tb.Text;

            if (passport_dgv.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (
                    int.TryParse(passportSeries_tb.Text, out passSeries) &&
                    int.TryParse(passportNumber_tb.Text, out passNum)
                    )
                {
                    passport_dgv.Rows[selectedRowIndex].SetValues(
                        passportID, documentsID, adressID, clientID,
                        clientName, clientSur, clientPat, passNum, passSeries, passBirth, passSex,
                        docsTIN, docsEducation,
                        adressRegion, adressCity, adressStreet, adressBuilding, adressApartment
                        );
                    passport_dgv.Rows[selectedRowIndex].Cells[18].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Не верно введены серия или номер!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void Search(DataGridView dgv, Database database, string searchQuery)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(searchQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        static public void DeleteRow(DataGridView dgv)
        {
            int index = dgv.CurrentCell.RowIndex;

            dgv.Rows[index].Visible = false;

            if (dgv.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                dgv.Rows[index].Cells[18].Value = RowState.Deleted;
                return;
            }

            dgv.Rows[index].Cells[18].Value = RowState.Deleted;
        }

        static public void CreateColumns(DataGridView dgv, string[] columns, string[] columnNames)
        {
            for (int i = 0; i < columns.Length; i++)
            {
                dgv.Columns.Add(columns[i], columnNames[i]);
            }

            dgv.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetInt32(0),
                record.GetInt32(1),
                record.GetInt32(2),
                record.GetInt32(3),
                record.GetString(4),
                record.GetString(5),
                record.GetString(6),
                record.GetInt32(7),
                record.GetInt32(8),
                record.GetString(9),
                record.GetString(10),
                record.GetString(11),
                record.GetString(12),
                record.GetString(13),
                record.GetString(14),
                record.GetString(15),
                record.GetString(16),
                record.GetString(17),
                RowState.ModifiedNew
            );
        }

        private void RefreshDataGrid(DataGridView dgv, Database database, string query)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();

            database.closeConnection();
        }

        // -----------------------------------------


        private void passportClear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void passportRefresh_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(passport_dgv, database, refreshQueryPassport);
        }

        private void passportSearch_btn_Click(object sender, EventArgs e)
        {
            Search(
                passport_dgv,
                database,
                @$"select
                    id_pk_passport, id_pk_document, id_pk_adress, id_pk_client,
                    p_name, p_surname, p_patronymic, p_number, p_series, p_birth, p_sex,
                    d_TIN, d_education,
                    a_region, a_city, a_street, a_building, a_apartment
                from UserDoc
                    inner join Documents D on D.id_pk_document = UserDoc.id_fk_doc
                    inner join Passport P on P.id_pk_passport = D.id_passport
                    inner join Client C on P.id_adress = C.id_adress
                    inner join Adress A on A.id_pk_adress = P.id_adress
                where concat([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) like '%{passportSearch_tb.Text}%'"
            );
        }

        private void clientSave_Click(object sender, EventArgs e)
        {
            Update(passport_dgv, database);
        }

        private void passport_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = passport_dgv.Rows[selectedRow];

                passportId_tb.Text = row.Cells[0].Value.ToString();
                passportNumber_tb.Text = row.Cells[7].Value.ToString();
                passportSeries_tb.Text = row.Cells[8].Value.ToString();
                passportBirth_tb.Text = row.Cells[9].Value.ToString();
                passportSex_cb.Text = row.Cells[10].Value.ToString();

                adressID_tb.Text = row.Cells[2].Value.ToString();
                adressRegion_tb.Text = row.Cells[13].Value.ToString();
                adressCity_tb.Text = row.Cells[14].Value.ToString();
                adressStreet_tb.Text = row.Cells[15].Value.ToString();
                adressBuilding_tb.Text = row.Cells[16].Value.ToString();
                adressApartment_tb.Text = row.Cells[17].Value.ToString();

                docsID_tb.Text = row.Cells[1].Value.ToString();
                docsTIN_tb.Text = row.Cells[11].Value.ToString();
                docsEducation_tb.Text = row.Cells[12].Value.ToString();

                clientID_tb.Text = row.Cells[3].Value.ToString();
                clientName_tb.Text = row.Cells[4].Value.ToString();
                clientSur_tb.Text = row.Cells[5].Value.ToString();
                clientPat_tb.Text = row.Cells[6].Value.ToString();
            }
        }

        private void passportAdd_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            int passID = Convert.ToInt32(passportId_tb.Text);
            int clientID = Convert.ToInt32(clientID_tb.Text);
            int adressID = Convert.ToInt32(adressID_tb.Text);
            int docsID = Convert.ToInt32(docsID_tb.Text);

            int passSeries, passNum;
            var passBirth = passportBirth_tb.Text;
            var passSex = passportSex_cb.Text;

            var adressRegion = adressRegion_tb.Text;
            var adressCity = adressCity_tb.Text;
            var adressStreet = adressStreet_tb.Text;
            var adressBuilding = adressBuilding_tb.Text;
            var adressApartment = adressApartment_tb.Text;

            var docsTIN = docsTIN_tb.Text;
            var docsEducation = docsEducation_tb.Text;

            var clientName = clientName_tb.Text;
            var clientSur = clientSur_tb.Text;
            var clientPat = clientPat_tb.Text;

            bool result = Checker($@"
                select id_pk_user from Users where u_name = '{clientName}' and u_surname = '{clientSur}';
            ");

            if (result)
            {
                MessageBox.Show(
                    "Такого пользователя не существует!",
                    "Не удалось добавить запись",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                if (
                    int.TryParse(passportSeries_tb.Text, out passSeries) &&
                    int.TryParse(passportNumber_tb.Text, out passNum)
                    )
                {
                    string query = $"EXEC ADDDocument " +
                            $"{passID}, {clientID}, {adressID}, {docsID},  " +
                            $"{passSeries}, {passNum}, '{passBirth}', '{passSex}'," +
                            $"'{adressRegion}', '{adressCity}', '{adressStreet}', '{adressBuilding}', '{adressApartment}', " +
                            $"'{docsTIN}', '{docsEducation}', '{clientName}', '{clientSur}', '{clientPat}';";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не верно введены серия или номер!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            database.closeConnection();
        }

        private void passportChange_btn_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void passportSearch_tb_TextChanged(object sender, EventArgs e)
        {
            Search(
                passport_dgv,
                database,
                @$"select
                    id_pk_passport, id_pk_document, id_pk_adress, id_pk_client,
                    p_name, p_surname, p_patronymic, p_number, p_series, p_birth, p_sex,
                    d_TIN, d_education,
                    a_region, a_city, a_street, a_building, a_apartment
                from UserDoc
                    inner join Documents D on D.id_pk_document = UserDoc.id_fk_doc
                    inner join Passport P on P.id_pk_passport = D.id_passport
                    inner join Client C on P.id_adress = C.id_adress
                    inner join Adress A on A.id_pk_adress = P.id_adress
                where concat(
                    id_pk_passport, id_pk_document, id_pk_adress, id_pk_client,
                    p_name, p_surname, p_patronymic, p_number, p_series, p_birth, p_sex,
                    d_TIN, d_education,
                    a_region, a_city, a_street, a_building, a_apartment
                ) like '%{passportSearch_tb.Text}%'"
            );
        }
    }
}
