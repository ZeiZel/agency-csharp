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
    public partial class Register : Form
    {
        Database database = new Database();

        public Register()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Form login = new Login();
            login.Show();

            Close();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            var loginUser = login_tb.Text;
            var passUser = password_tb.Text;
            var nameUser = name_tb.Text;
            var numberUser = number_tb.Text;
            var surnameUser = surname_tb.Text;
            var emailUser = mail_tb.Text;
            var patronymicUser = thirdname_tb.Text;

            bool result = checkUser();

            if (result)
            {
                if (login_tb.Text.Length > 0 &&
                password_tb.Text.Length > 0 &&
                name_tb.Text.Length > 0 &&
                number_tb.Text.Length > 0 &&
                surname_tb.Text.Length > 0 &&
                mail_tb.Text.Length > 0 &&
                thirdname_tb.Text.Length > 0
                )
                {
                    string queryString = $"insert into [dbo].[User]([name], [login], [email], [password], [phoneNumber], [surname], [patronymic]) values('{nameUser}', '{loginUser}', '{emailUser}', '{passUser}', '{numberUser}', '{surnameUser}', '{patronymicUser}');";

                    SqlCommand command = new SqlCommand(queryString, database.getConnection());
                    database.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        Form success = new SuccessForm();
                        success.Show();
                        this.Close();
                    }
                    else
                    {
                        Form error = new ErrorForm();
                        error.Show();
                        this.Close();
                    }

                    database.closeConnection();
                }
                else
                {
                    MessageBox.Show("Введите данные во все поля", "Зарегистрироваться не удалось", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private Boolean checkUser()
        {
            var loginUser = login_tb.Text;
            var passUser = password_tb.Text;

            string queryString = $"select [id], [email], [password], [name] from [dbo].[User] where [name] = '{loginUser}' and [password] = '{passUser}'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже есть!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите всё стереть?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                password_tb.Text = "";
                login_tb.Text = "";
                name_tb.Text = "";
                thirdname_tb.Text = "";
                surname_tb.Text = "";
                mail_tb.Text = "";
                number_tb.Text = "";
            }
        }
    }
}
