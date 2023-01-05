using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace agency_csharp
{
    public partial class Vacancy : Form
    {
        private readonly CheckUser _user;
        Database database = new Database();
        int selectedRow;

        public Vacancy(CheckUser user)
        {
            _user = user;
            StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();
            обновленияToolStripMenuItem.Visible = false;

            CreateColumns(vacancy_dgv);
            RefreshDataGrid(
                vacancy_dgv,
                "select id_pk_vacancy, id_pk_adress, O.o_name, v_profession, v_description, a_region, a_city, a_street, a_building, a_apartment from Vacancy, Organization, Adress inner join Organization O on Adress.id_pk_adress = O.id_fk_adress"
            );
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetInt32(0),
                record.GetInt32(1),
                record.GetString(2),
                record.GetString(3),
                record.GetString(4),
                record.GetString(5),
                record.GetString(6),
                record.GetString(7),
                record.GetString(8),
                record.GetString(9)
            );
        }

        private void CreateColumns(DataGridView dgv)
        {
            dgv.Columns.Add("id_pk_vacancy", "Id Вакансии");
            dgv.Columns.Add("id_pk_adress", "Id Адреса");

            dgv.Columns.Add("o_name", "Организация");
            dgv.Columns.Add("v_profession", "Должность");
            dgv.Columns.Add("v_description", "Номер телефона");

            dgv.Columns.Add("a_region", "Регион");
            dgv.Columns.Add("a_city", "Населённый пункт");
            dgv.Columns.Add("a_street", "Улица");
            dgv.Columns.Add("a_building", "Строение");
            dgv.Columns.Add("a_apartment", "Квартира");
        }

        private void RefreshDataGrid(DataGridView dgv, string query)
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

        private void Search(DataGridView dgv, string query)
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

        private void ClearFields()
        {
            vacancyID_tb.Text = "";
            vacName_tb.Text = "";
            vacNum_tb.Text = "";
            vacOrgName_tb.Text = "";

            adressApartment_tb.Text = "";
            adressBuilding_tb.Text = "";
            adressCity_tb.Text = "";
            adressId_tb.Text = "";
            adressRegion_tb.Text = "";
            adressStreet_tb.Text = "";
        }

        private void Vacancy_Load(object sender, EventArgs e)
        {
            userStatus_tstb.Text = $"{_user.Login}: {_user.Status}";
        }

        private void userStatus_tstb_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
        }

        private void обновленияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vacClrear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(
                vacancy_dgv,
                "select id_pk_vacancy, id_pk_adress, O.o_name, v_profession, v_description, a_region, a_city, a_street, a_building, a_apartment from Vacancy, Organization, Adress inner join Organization O on Adress.id_pk_adress = O.id_fk_adress"
            );
        }

        private void response_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var selectedRowIndex = vacancy_dgv.CurrentCell.RowIndex;

            var userName = _user.Login;
            var vacancyId = vacancy_dgv.Rows[selectedRowIndex].Cells[0].Value.ToString();

            string queryResponse = $"EXEC ResponseUserInsert {userName}, {vacancyId}";
            SqlCommand command = new SqlCommand(queryResponse, database.getConnection());
            command.ExecuteNonQuery();

            database.closeConnection();

            MessageBox.Show("Отклик на вакансию отправлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void vacancy_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = vacancy_dgv.Rows[selectedRow];

                vacancyID_tb.Text = row.Cells[0].Value.ToString();
                vacOrgName_tb.Text = row.Cells[2].Value.ToString();
                vacName_tb.Text = row.Cells[3].Value.ToString();
                vacNum_tb.Text = row.Cells[4].Value.ToString();
                
                adressId_tb.Text = row.Cells[1].Value.ToString();
                adressRegion_tb.Text = row.Cells[5].Value.ToString();
                adressCity_tb.Text = row.Cells[6].Value.ToString();
                adressStreet_tb.Text = row.Cells[7].Value.ToString();
                adressBuilding_tb.Text = row.Cells[8].Value.ToString();
                adressApartment_tb.Text = row.Cells[9].Value.ToString();
            }
        }

        private void vacSearch_tb_TextChanged(object sender, EventArgs e)
        {
            Search(
                vacancy_dgv, 
                $"select id_pk_vacancy, id_pk_adress, O.o_name, v_profession, v_description, a_region, a_city, a_street, a_building, a_apartment from Vacancy, Organization, Adress inner join Organization O on Adress.id_pk_adress = O.id_fk_adress where concat(id_pk_vacancy, id_pk_adress, O.o_name, v_profession, v_description, a_region, a_city, a_street, a_building, a_apartment) like '%{vacSearch_tb.Text}%'"
            );

        }

        private void vacSearch_btn_Click(object sender, EventArgs e)
        {
            Search(
                vacancy_dgv,
                $"select id_pk_vacancy, id_pk_adress, O.o_name, v_profession, v_description, a_region, a_city, a_street, a_building, a_apartment from Vacancy, Organization, Adress inner join Organization O on Adress.id_pk_adress = O.id_fk_adress where concat(id_pk_vacancy, id_pk_adress, O.o_name, v_profession, v_description, a_region, a_city, a_street, a_building, a_apartment) like '%{vacSearch_tb.Text}%'"
            );
        }

        private void Vacancy_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form login = new Login();
            login.Show();
        }
    }
}
