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
        /// Создание колонок в датагриде
        /// </summary>
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
        static public void ReadSingleRow(DataGridView dgv, IDataRecord record)
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
        static public void RefreshDataGrid(DataGridView dgv, Database database)
        {
            dgv.Rows.Clear();

            string query =
                "select id_pk_user, u_name, u_surname, u_patronymic, u_phoneNumber from Users inner join Employee E on Users.id_pk_user = E.id_fk_user;";

            SqlCommand command = new SqlCommand(query, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();

            // закрыть (!!)
            database.closeConnection();
        }
    }
}
