using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace agency_csharp
{
    public partial class Login : Form
    {
        Database database = new Database();

        public Login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            password_tb.PasswordChar = '●';
            openedEye_pb.Visible = false;
            login_tb.MaxLength = 50;
            password_tb.MaxLength = 50;
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Form register = new Register();
            register.Show();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var loginUser = login_tb.Text;
            var passUser = password_tb.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select id, email, password, name from UserModel where name = '{loginUser}' and password = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form mainWindow = new MainWindow();
            }
        }
    }
}