using Microsoft.Data.SqlClient;
using System.Data;

namespace agency_csharp
{
    public partial class AddOrganization : Form
    {
        Database database = new Database();

        public AddOrganization()
        {
            InitializeComponent();
        }

        private void AddOrganization_Load(object sender, EventArgs e)
        {

        }

        private void orgDel_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Уведомление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void orgAdd_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var orgName = orgName_tb.Text;
            var orgNum = orgNum_tb.Text;
            var orgMail = orgMail_tb.Text;
            var orgClient = orgClient_tb.Text;

            var adressRegion = adressRegion_tb.Text;
            var adressCity = adressCity_tb.Text;
            var adressStreet = adressStreet_tb.Text;
            var adressBuilding = adressBuilding_tb.Text;
            var adressApartment = adressApartment_tb.Text;

            bool result = CheckOrganization($"select id_pk_organization from Organization where o_name = {orgName} and o_phoneNumber = '{orgNum}'");
            bool findNumber = CheckOrganization($"select id_pk_organization from Organization where o_phoneNumber = '{orgNum}'");

            if (result)
            {
                if (Int64.TryParse(orgNum, out Int64 n))
                {
                    if (findNumber)
                    {
                        if (
                        orgName.Length > 0 && orgName.Length < 50 &&
                        orgNum.Length > 0 && orgNum.Length < 50 &&
                        orgMail.Length > 0 && orgMail.Length < 50 &&
                        orgClient.Length > 0 && orgClient.Length < 50 &&
                        adressRegion.Length > 0 && adressRegion.Length < 50 &&
                        adressCity.Length > 0 && adressCity.Length < 50 &&
                        adressStreet.Length > 0 && adressStreet.Length < 50 &&
                        adressBuilding.Length > 0 && adressBuilding.Length < 50 &&
                        adressApartment.Length > 0 && adressApartment.Length < 50
                        )
                        {
                            string queryString =
                            $"EXEC AddOrganization '{orgName}', '{orgClient}', '{orgNum}', '{orgMail}', " +
                            $"'{adressRegion}', '{adressCity}', '{adressStreet}', '{adressBuilding}', '{adressApartment}';";
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
                        "Такой номер телефона уже есть в базе!",
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
                        "Такая организация уже существует",
                        "Не удалось добавить запись",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
            }

            database.closeConnection();
        }

        private Boolean CheckOrganization(string query)
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
    }
}
