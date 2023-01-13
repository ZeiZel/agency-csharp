using Microsoft.Data.SqlClient;
using System.Data;

namespace agency_csharp
{
    static class Utilities
    {
        /// <summary>
        /// Осуществление поиска в определённом датагриде
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="database"></param>
        /// <param name="searchQuery"></param>
        static public void Search(DataGridView dgv, Database database, SwitchState state, string searchQuery)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(searchQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Utilities.ReadSingleRow(dgv, reader, state);
            }

            reader.Close();
            database.closeConnection();
        }

        /// <summary>
        /// Функция удаления строки
        /// </summary>
        /// <param name="dgv"></param>
        static public void DeleteRow(DataGridView dgv)
        {
            // индекс строки, в которой сейчас находимся
            int index = dgv.CurrentCell.RowIndex;

            dgv.Rows[index].Visible = false;

            // если строка пустая
            if (dgv.Rows[index].Cells[0].Value.ToString() == string.Empty)
            {
                // то состояние строки будет = удалённой
                dgv.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }

            dgv.Rows[index].Cells[5].Value = RowState.Deleted;
        }


        /// <summary>
        /// Создание колонок в датагриде
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="columns"></param>
        /// <param name="columnNames"></param>
        static public void CreateColumns(DataGridView dgv, string[] columns, string[] columnNames)
        {
            for (int i = 0; i < columns.Length; i++)
            {
                dgv.Columns.Add(columns[i], columnNames[i]);
            }

            dgv.Columns.Add("IsNew", String.Empty);
        }

        /// <summary>
        /// Вывод одной строки в датагрид
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="record"></param>
        static public void ReadSingleRow(DataGridView dgv, IDataRecord record, SwitchState state)
        {
            switch (state)
            {
                case SwitchState.Employee:
                case SwitchState.Client:
                    dgv.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1),
                        record.GetString(2),
                        record.GetString(3),
                        record.GetString(4),
                        RowState.ModifiedNew
                    );
                    break;
                case SwitchState.Organization:
                    dgv.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1),
                        record.GetString(2),
                        record.GetString(3),
                        record.GetString(4),
                        RowState.ModifiedNew
                    );
                    break;
                case SwitchState.Vacancy:
                    dgv.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1),
                        record.GetString(2),
                        record.GetString(3),
                        record.GetString(4),
                        RowState.ModifiedNew
                    );
                    break;
                case SwitchState.Contract:
                    dgv.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1),
                        record.GetString(2),
                        record.GetString(3),
                        record.GetString(4),
                        record.GetString(5),
                        record.GetString(6),
                        record.GetString(7),
                        RowState.ModifiedNew
                    );
                    break;
                case SwitchState.Response:
                    dgv.Rows.Add(
                        record.GetInt32(0),
                        record.GetString(1),
                        record.GetString(2),
                        record.GetString(3),
                        record.GetString(4),
                        record.GetString(5),
                        record.GetString(6),
                        record.GetString(7),
                        RowState.ModifiedNew
                    );
                    break;
                case SwitchState.Passport:
                    dgv.Rows.Add(
                        record.GetInt32(0),
                        record.GetInt32(1),
                        record.GetInt32(2),
                        record.GetInt32(3),
                        record.GetString(4),
                        record.GetString(5),
                        record.GetString(6),
                        record.GetString(7),
                        record.GetString(8),
                        record.GetString(9),
                        record.GetString(10),
                        record.GetString(11),
                        record.GetString(12),
                        record.GetString(13),
                        record.GetString(14),
                        record.GetString(15),
                        record.GetString(16),
                        record.GetString(17),
                        RowState.ModifiedNew
                    );
                    break;
                default:
                    MessageBox.Show("Внутренняя ошибка вызова состояния");
                    break;
            }
        }

        /// <summary>
        /// Обновление выбранного датагрида 
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="database"></param>
        static public void RefreshDataGrid(DataGridView dgv, Database database, SwitchState state, string query)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader, state);
            }

            reader.Close();

            database.closeConnection();
        }
    }
}
