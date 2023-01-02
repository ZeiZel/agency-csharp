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
        private readonly CheckUser _user;
        Database database = new Database();

        int selectedRow;

        public MainWindow(CheckUser user)
        {
            _user = user;


            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        // Определяет уровень доступа для админа
        private void IsAdmin()
        {
            // если пользователь админ, то IsAdmin будет = true
            управлениеToolStripMenuItem.Enabled = _user.IsAdmin;
            add_btn.Visible = _user.IsAdmin;
        }

        // Определяет уровень доступа для работника
        private void IsEmployee()
        {
            // если пользователь админ, то IsAdmin будет = true
            управлениеToolStripMenuItem.Enabled = _user.IsEmployee;
            add_btn.Visible = _user.IsEmployee;
        }

        /// <summary>
        /// Создание колонок в датагриде
        /// </summary>
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_pk_user", "Идентификатор");
            dataGridView1.Columns.Add("u_name", "Имя");
            dataGridView1.Columns.Add("u_surname", "Фамилия");
            dataGridView1.Columns.Add("u_patronymic", "Отчество");
            dataGridView1.Columns.Add("u_phoneNumber", "Контактный номер");

            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        /// <summary>
        /// Вывод одной строки в датагрид
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="record"></param>
        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(
                record.GetInt32(0),
                record.GetString(1), 
                record.GetString(2), 
                record.GetString(3), 
                record.GetString(4), 
                RowState.ModifiedNew
            );
        }

        /// <summary>
        /// Обновление выбранного датагрида 
        /// </summary>
        /// <param name="dgv"></param>
        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string query = "select * from [dbo].[Users]";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
        }

        /// <summary>
        /// Осуществление поиска в определённом датагриде
        /// </summary>
        /// <param name="dgv"></param>
        private void Search(DataGridView dgv, string searchQuery)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(searchQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        // Функция удаления строки
        private void DeleteRow()
        {
            // индекс строки, в которой сейчас находимся
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            // если строка пустая
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                // то состояние строки будет = удалённой
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
        }

        // Этот метод будет проверить состояние клетки
        private void Update()
        {
            database.openConnection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var rowState = (RowState)dataGridView1.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                    string query = $"delete from [dbo].[Users] where [id_pk_user] = {id}";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                }

                if (rowState == RowState.Modified)
                {
                    var userId = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    var userName = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    var userSurname = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    var userPatronymic = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    var userNumber = dataGridView1.Rows[i].Cells[4].Value.ToString();

                    string query =
                        $"update [dbo].[Users] set [u_name] = '{userName}', [u_phoneNumber] = '{userNumber}', [u_surname] = '{userSurname}', [u_patronymic] = '{userPatronymic}' where [id_pk_user] = {userId};";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        // Этот метод будет производить изменение данных
        private void Change()
        {
            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = userId.Text;
            var userName = name_tb.Text;
            var userSurname = surname_tb.Text;
            var userPatronymic = thirdname_tb.Text;
            Int64 userNumber;

            if (dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                if (Int64.TryParse(number_tb.Text, out userNumber))
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(id, userName, userSurname, userPatronymic, userNumber);
                    dataGridView1.Rows[selectedRowIndex].Cells[5].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("Номер телефона введён неверный!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ClearFields()
        {
            userId.Text = "";
            name_tb.Text = "";
            surname_tb.Text = "";
            thirdname_tb.Text = "";
            number_tb.Text = "";
        }

        // ------------------------------------------------------------------------------------------------

        private void MainWindow_Load(object sender, EventArgs e)
        {
            userStatus_tstb.Text = $"{_user.Login}: {_user.Status}";
            IsAdmin();
            IsEmployee();
        }

        /// <summary>
        /// Ввод выбранной записи в датагриде внутрь текстбоксов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;

            // проверка e.Row проводится для того, чтобы не выводилась ошибка выхода из диапазона
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                userId.Text = row.Cells[0].Value.ToString();
                name_tb.Text = row.Cells[1].Value.ToString();
                surname_tb.Text = row.Cells[2].Value.ToString();
                thirdname_tb.Text = row.Cells[3].Value.ToString();
                number_tb.Text = row.Cells[4].Value.ToString();
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        /// <summary>
        /// Добавление нового работника во вкладке сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_btn_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var userName = name_tb.Text;
            var userSurname = surname_tb.Text;
            var userPatronymic = thirdname_tb.Text;
            var userNumber = number_tb.Text;

            if (Int64.TryParse(userNumber, out Int64 n))
            {
                string queryString = $"insert into [dbo].[Users] ([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) values('{userName}', '{userSurname}', '{userPatronymic}', '{userNumber}');";
                SqlCommand command = new SqlCommand(queryString, database.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Запись добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный номер телефона", "Не удалось добавить запись", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            database.closeConnection();
            RefreshDataGrid(dataGridView1);
        }

        /// <summary>
        /// Кнопка очистки данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clear_btn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        /// <summary>
        /// Рефреш датагрида
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clientRefresh_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(clientView_dgv);
        }

        private void orgRefresh_btn_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(organization_dgv);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(vacancy_dgv);
        }

        /// <summary>
        /// Дальше идут кнопки поиска записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1, $"select * from [dbo].[Users] where concat([u_name], [u_surname], [u_patronymic], [u_phoneNumber]) like '%{search_tb.Text}%'");
        }

        private void clientSearch_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void orgSearch_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void vacSearch_tb_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Дальше идут кнопки удаления записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, EventArgs e)
        {
            // тут мы помечаем под удаление ячейку и после сохранения все изменения вступят в силу
            DeleteRow();
        }

        private void clientDel_Click(object sender, EventArgs e)
        {

        }

        private void orgDel_btn_Click(object sender, EventArgs e)
        {

        }

        private void vacDel_tb_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Дальше пойдут кнопки редактирования данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void change_btn_Click(object sender, EventArgs e)
        {
            Change();
        }

        private void clientChange_Click(object sender, EventArgs e)
        {

        }

        private void orgChange_btn_Click(object sender, EventArgs e)
        {

        }

        private void vacChange_tb_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Дапльше пойдёт кнопка сохранения данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_btn_Click(object sender, EventArgs e)
        {
            // чтобы работало удаление, нужно в сохранение запихнуть обновление
            Update();
        }

        private void clientSave_Click(object sender, EventArgs e)
        {

        }

        private void orgSave_btn_Click(object sender, EventArgs e)
        {

        }

        private void vacSave_tb_Click(object sender, EventArgs e)
        {

        }
    }
}
