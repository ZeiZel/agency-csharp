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
            dataGridView1.Columns.Add("id_pk_register", "Id регистрации");
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
            dataGridView1.Columns.Add("id_fk_user", "Id пользователя");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetInt32(0), 
                record.GetString(1), 
                record.GetString(2), 
                record.GetBoolean(3), 
                record.GetBoolean(4),
                record.GetInt32(5)
            );
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            string query = "select [id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee], [id_fk_user] from [dbo].[Register]";

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
                var idUser = dataGridView1.Rows[i].Cells[5].Value.ToString();

                // !!
                string changeQuery = $"update Register SET r_isAdmin = '{isAdmin}', r_isEmployee = '{isEmployee}' where id_pk_register = {id}";
                string queryEmployee = $"select [id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee] from [dbo].[Register]";

                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value))
                {
                    string queryStringCheck = $"select * from Employee where id_fk_user = {id}";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    SqlCommand commandCheck = new SqlCommand(queryStringCheck, database.getConnection());

                    adapter.SelectCommand = commandCheck;
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        queryEmployee = $"EXEC AddUserEmployee {idUser}";
                    }
                } else
                {
                    queryEmployee = $"delete from Employee where id_fk_user = {id}";
                }

                SqlCommand command = new SqlCommand(changeQuery, database.getConnection());
                command.ExecuteNonQuery();

                SqlCommand commandAddEmp = new SqlCommand(queryEmployee, database.getConnection());
                commandAddEmp.ExecuteNonQuery();
            }

            database.closeConnection();
            RefreshDataGrid();
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1, $"select [id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee], [id_fk_user] from [dbo].[Register] where concat([id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee], [id_fk_user]) like '%{search_tb.Text}%'");

        }

        private void search_grid_btn_Click(object sender, EventArgs e)
        {
            Search(dataGridView1, $"select [id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee], [id_fk_user] from [dbo].[Register] where concat([id_pk_register], [r_login], [r_password], [r_isAdmin], [r_isEmployee], [id_fk_user]) like '%{search_tb.Text}%'");

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            search_tb.Text = "";
        }
    }
}
