using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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

            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var loginUser = login_tb.Text;
            var passUser = PasswordEncrypt.HashPassword(password_tb.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();


            if (login_tb.Text.Length > 0 && password_tb.Text.Length > 0)
            {
                string queryString = $"select * from Register where [r_login] = '{loginUser}' and [r_password] = '{passUser}'";

                SqlCommand command = new SqlCommand(queryString, database.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    var userLogin = table.Rows[0].ItemArray[3].ToString();
                    var isAdmin = Convert.ToBoolean(table.Rows[0].ItemArray[5]);
                    var isEmployee = Convert.ToBoolean(table.Rows[0].ItemArray[7]);
                    var user = new CheckUser(userLogin, isAdmin, isEmployee);

                    if (isAdmin == true || isEmployee == true)
                    {
                        MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form mainWindow = new MainWindow(user);
                        mainWindow.Show();
                    } else
                    {
                        Form vacancy = new Vacancy(user);
                        vacancy.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("К сожалению, данные были введены некорректно либо такого аккаунта не существует", "Войти не удалось", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("Введите данные во все поля", "Зарегистрироваться не удалось", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите всё стереть?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                password_tb.Text = "";
                login_tb.Text = "";
            }
            
        }

        private void openedEye_pb_Click(object sender, EventArgs e)
        {
            password_tb.UseSystemPasswordChar = false;
            openedEye_pb.Visible = false;
            closedEye_pb.Visible = true;
        }

        private void closedEye_pb_Click(object sender, EventArgs e)
        {
            password_tb.UseSystemPasswordChar = true;
            openedEye_pb.Visible = true;
            closedEye_pb.Visible = false;
        }
    }
}