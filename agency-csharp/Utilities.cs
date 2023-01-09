using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

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
        static public void Search(DataGridView dgv, Database database, string searchQuery)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(searchQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Utilities.ReadSingleRow(dgv, reader);
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
        static public void ReadSingleRowEmpCli(DataGridView dgv, IDataRecord record)
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
        /// <param name="database"></param>
        static public void RefreshDataGridEmpCli(DataGridView dgv, Database database, string query)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRowEmpCli(dgv, reader);
            }

            reader.Close();

            database.closeConnection();
        }

        static public void RefreshDataGridOrg(DataGridView dgv, Database database, string query)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dgv.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    RowState.ModifiedNew
                );
            }

            reader.Close();

            database.closeConnection();
        }

        static public void RefreshDataGridVac(DataGridView dgv, Database database, string query)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dgv.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    RowState.ModifiedNew
                );
            }

            reader.Close();

            database.closeConnection();
        }

        static public void RefreshDataGridContracts(DataGridView dgv, Database database, string query)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dgv.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    RowState.ModifiedNew
                );
            }

            reader.Close();

            database.closeConnection();
        }

        static public void RefreshDataGridResp(DataGridView dgv, Database database, string query)
        {
            dgv.Rows.Clear();

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dgv.Rows.Add(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    RowState.ModifiedNew
                );
            }

            reader.Close();

            database.closeConnection();
        }
    }
}
