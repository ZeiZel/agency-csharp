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
                "select * from [dbo].[Vacancy]"
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
            dgv.Columns.Add("id_pk_vacancy", "Id организации");
            dgv.Columns.Add("id_pk_adress", "Id Адреса");

            dgv.Columns.Add("o_name", "Организация");
            dgv.Columns.Add("u_surname", "Должность");
            dgv.Columns.Add("u_patronymic", "Номер телефона");

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
                "select * from [dbo].[Vacancy]"
            );
        }
    }
}
