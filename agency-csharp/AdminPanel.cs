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
    public partial class AdminPanel : Form
    {
        Database database = new Database();

        public AdminPanel()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_pk_register", "ID");
            dataGridView1.Columns.Add("r_login", "Логин");
            dataGridView1.Columns.Add("r_password", "Пароль");
            //dataGridView1.Columns.Add("r_isAdmin", "Права администратора");
            //dataGridView1.Columns.Add("r_isEmployee", "Права работника");

            var checkColumnAdmin = new DataGridViewCheckBoxColumn();
            checkColumnAdmin.HeaderText = "r_isAdmin";

            var checkColumnEmployee = new DataGridViewCheckBoxColumn();
            checkColumnEmployee.HeaderText = "r_isEmployee";

            dataGridView1.Columns.Add(checkColumnAdmin);
            dataGridView1.Columns.Add(checkColumnEmployee);
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetInt32(0), 
                record.GetString(1), 
                record.GetString(2), 
                record.GetBoolean(3), 
                record.GetBoolean(4)
            );
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            string query = "select [id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee] from [dbo].[Register]";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void Search(DataGridView dgv, string searchQuery)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(searchQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dataGridView1, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                var isAdmin = dataGridView1.Rows[i].Cells[3].Value.ToString();
                var isEmployee = dataGridView1.Rows[i].Cells[4].Value.ToString();

                // !!
                string changeQuery = $"update Register SET r_isAdmin = '{isAdmin}', r_isEmployee = '{isEmployee}' where id_pk_register = {id}";

                SqlCommand command = new SqlCommand(changeQuery, database.getConnection());
                command.ExecuteNonQuery();
            }

            database.closeConnection();
            RefreshDataGrid();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var selectedRowIntex = dataGridView1.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dataGridView1.Rows[selectedRowIntex].Cells[0].Value);

            var deleteUserQuery = $"EXEC DeleteUserFromRegister {id}";
            SqlCommand commandDel = new SqlCommand(deleteUserQuery, database.getConnection());

            var deleteQuery = $"delete from Register where id_pk_register = {id};";
            SqlCommand command = new SqlCommand(deleteQuery, database.getConnection());

            if (commandDel.ExecuteNonQuery() == 0 && command.ExecuteNonQuery() == 0)
            {
                MessageBox.Show("Текст");
            }
            
            database.closeConnection();
            RefreshDataGrid();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1, $"select [id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee] from [dbo].[Register] where concat([id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee]) like '%{search_tb.Text}%'");

        }

        private void search_grid_btn_Click(object sender, EventArgs e)
        {
            Search(dataGridView1, $"select [id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee] from [dbo].[Register] where concat([id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee]) like '%{search_tb.Text}%'");

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            search_tb.Text = "";
        }
    }
}
