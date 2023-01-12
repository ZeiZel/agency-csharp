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
            var passUser = PasswordEncrypt.HashPassword(password_tb.Text);
            var nameUser = name_tb.Text;
            var numberUser = number_tb.Text;
            var surnameUser = surname_tb.Text;
            var emailUser = mail_tb.Text;
            var patronymicUser = thirdname_tb.Text;

            bool result = CheckUser();

            bool isNumeric = Int64.TryParse(numberUser, out Int64 n) && numberUser.Length == 10;

            try
            {
                if (result)
                {
                    if (isNumeric)
                    {
                        if (
                            login_tb.Text.Length > 0 &&
                            password_tb.Text.Length > 0 &&
                            name_tb.Text.Length > 0 &&
                            number_tb.Text.Length > 0 &&
                            surname_tb.Text.Length > 0 &&
                            mail_tb.Text.Length > 0 &&
                            thirdname_tb.Text.Length > 0 &&
                            login_tb.Text.Length < 51 &&
                            password_tb.Text.Length < 51 &&
                            name_tb.Text.Length < 51 &&
                            number_tb.Text.Length < 51 &&
                            surname_tb.Text.Length < 51 &&
                            mail_tb.Text.Length < 101 &&
                            thirdname_tb.Text.Length < 51
                        )
                        {
                            database.openConnection();

                            string queryUser = $"insert into Users (u_name, u_surname, u_patronymic, u_phoneNumber) values('{nameUser}', '{surnameUser}', '{patronymicUser}', '{numberUser}');";
                            SqlCommand commandUser = new SqlCommand(queryUser, database.getConnection());

                            //string queryRegister = $"insert into Register (id_fk_user, r_email, r_login, r_password, r_isAdmin, r_isUser, r_isEmployee) values('{userId}', '{emailUser}', '{loginUser}', '{passUser}', 0, 1, 0);";
                            string queryRegister = $"EXEC CreateFKRegister '{nameUser}', '{emailUser}', '{loginUser}', '{passUser}', 0, 1, 0;";
                            SqlCommand commandRegister = new SqlCommand(queryRegister, database.getConnection());

                            if (commandUser.ExecuteNonQuery() == 1 && commandRegister.ExecuteNonQuery() == 1)
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
                            MessageBox.Show("Введите данные во все поля. Либо уложитесь в 50 символов для всех полей и в 100 для почты.", "Зарегистрироваться не удалось", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ваш номер телефона введён неправильно (вводите без \"+7\")", "Зарегистрироваться не удалось", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже есть!");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Произошла совсем непредвиденная ошибка, связанная с базой данных");
            }
        }

        private Boolean CheckUser()
        {
            var loginUser = login_tb.Text;
            var passUser = password_tb.Text;

            int length = GetLength($"select [r_login], [r_password], [r_isAdmin], [r_isUser], [r_isEmployee] from [dbo].[Register] where [r_login] = '{loginUser}' and [r_password] = '{passUser}'");            

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

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form login = new Login();
            login.Show();
        }
    }
}
