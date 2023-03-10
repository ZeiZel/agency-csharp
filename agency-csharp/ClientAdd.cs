using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agency_csharp
{
    public partial class ClientAdd : Form
    {
        Database database = new Database();

        public ClientAdd()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ClientAdd_Load(object sender, EventArgs e)
        {
            sex_cb.Visible = false;
            profession_tb.Visible = false;
            birth_tb.Visible = false;
            education_tb.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var clientName = clientName_tb.Text;
            var clientSurname = clientSur_tb.Text;
            var clientPat = clientPat_tb.Text;
            var clientNum = clientNum_tb.Text;

            var adressRegion = adressRegion_tb.Text;
            var adressCity = adressCity_tb.Text;
            var adressStreet = adressStreet_tb.Text;
            var adressBuilding = adressBuilding_tb.Text;
            var adressApartment = adressApartment_tb.Text;

            bool status = clientStatus_cb.Checked;
            var clientSex = sex_cb.Text;
            var clientBirth = birth_tb.Text;
            var clientEducation = education_tb.Text;
            var clientProfession = profession_tb.Text;

            bool result = CheckClient($"select u_name, u_phoneNumber, u_patronymic, u_surname from Users where u_name = '{clientName}' and u_phoneNumber = '{clientNum}' and u_patronymic = '{clientPat}' and u_surname = '{clientSurname}';");
            bool findNumber = CheckClient($"select u_phoneNumber from Users where u_phoneNumber = '{clientNum}';");

            if (result)
            {
                if (Int64.TryParse(clientNum, out Int64 n))
                {
                    if (findNumber)
                    {
                        if (
                        clientName.Length > 0 && clientName.Length < 50 &&
                        clientSurname.Length > 0 && clientSurname.Length < 50 &&
                        clientPat.Length > 0 && clientPat.Length < 50 &&
                        clientNum.Length > 0 && clientNum.Length < 50 &&
                        adressRegion.Length > 0 && adressRegion.Length < 50 &&
                        adressCity.Length > 0 && adressCity.Length < 50 &&
                        adressStreet.Length > 0 && adressStreet.Length < 50 &&
                        adressBuilding.Length > 0 && adressBuilding.Length < 50 &&
                        adressApartment.Length > 0 && adressApartment.Length < 50
                        )
                        {
                            string queryString =
                            @$"
                                EXEC AddClient 
                                '{clientName}', '{clientSurname}', '{clientPat}', '{clientNum}',
                                '{adressRegion}', '{adressCity}', '{adressStreet}', '{adressBuilding}', '{adressApartment}',
                                '{status}', '{clientSex}', '{clientBirth}', '{clientEducation}', '{clientProfession}'
                            ;";

                            SqlCommand command = new SqlCommand(queryString, database.getConnection());
                            command.ExecuteNonQuery();

                            MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Вы ввели не все данные, либо одно из ваших полей занимает > 50 символов",
                                "Не удалось добавить запись",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Такой номер уже добавлен в базу!",
                            "Не удалось добавить запись",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Пожалуйста, введите корректный номер телефона",
                        "Не удалось добавить запись",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                        "Такой пользователь уже существует",
                        "Не удалось добавить запись",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
            }



            database.closeConnection();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }

        private Boolean CheckClient(string query)
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

        private void clientStatus_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (clientStatus_cb.CheckState == CheckState.Unchecked)
            {
                sex_cb.Visible = false;
                profession_tb.Visible = false;
                birth_tb.Visible = false;
                education_tb.Visible = false;

                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            } else
            {
                sex_cb.Visible = true;
                profession_tb.Visible = true;
                birth_tb.Visible = true;
                education_tb.Visible = true;

                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
            }
        }
    }
}
