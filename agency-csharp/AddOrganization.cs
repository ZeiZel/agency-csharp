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
    public partial class AddOrganization : Form
    {
        public AddOrganization()
        {
            InitializeComponent();
        }

        private void AddOrganization_Load(object sender, EventArgs e)
        {
            //database.openConnection();

            ////var id = Convert.ToInt32(userId_tb.Text);
            //var userName = name_tb.Text;
            //var userSurname = surname_tb.Text;
            //var userPatronymic = thirdname_tb.Text;
            //var userNumber = number_tb.Text;

            //if (Int64.TryParse(userNumber, out Int64 n))
            //{
            //    string queryString = $"insert into [dbo].[Users] ([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) values('{userName}', '{userSurname}', '{userPatronymic}', '{userNumber}');";
            //    SqlCommand command = new SqlCommand(queryString, database.getConnection());
            //    command.ExecuteNonQuery();

            //    string queryAddEmployee = $"EXEC AddUserEmployee  {userName}, {userNumber}";
            //    SqlCommand commandAddEmp = new SqlCommand(queryAddEmployee, database.getConnection());
            //    commandAddEmp.ExecuteNonQuery();

            //    MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Пожалуйста, введите корректный номер телефона", "Не удалось добавить запись", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //database.closeConnection();
        }
    }
}
