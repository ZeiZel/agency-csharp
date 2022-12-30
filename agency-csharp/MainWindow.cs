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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainWindow : Form
    {
        Database database = new Database();

        int selectedRow;

        public MainWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("patronymic", "Отчество");
            dataGridView1.Columns.Add("phoneNumber", "Контактный номер");
            dataGridView1.Columns.Add("email", "Почта");

            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetInt32(0), 
                record.GetString(1), 
                record.GetString(2), 
                record.GetString(3), 
                record.GetString(4), 
                record.GetString(5),
                RowState.ModifiedNew
            );
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = "select * from [dbo].[User]";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
