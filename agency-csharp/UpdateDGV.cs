using Microsoft.Data.SqlClient;

namespace agency_csharp
{
    static class UpdateDGV
    {
        /// <summary>
        /// Этот метод будет отправлять изменения таблиц в базу данных
        /// </summary>
        static public void Employees(DataGridView dgv, Database database)
        {
            database.openConnection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var rowState = (RowState)dgv.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);

                    database.openConnection();

                    var deleteEmployeeQuery = $"delete from Employee where id_fk_user = {id}";
                    SqlCommand commandEmpDel = new SqlCommand(deleteEmployeeQuery, database.getConnection());

                    var deleteEmployeeRulesQuery = $"update Register SET r_isEmployee = 'False' where id_pk_register = {id}";
                    SqlCommand commandEmpDelRules = new SqlCommand(deleteEmployeeQuery, database.getConnection());

                    if (
                            commandEmpDel.ExecuteNonQuery() == 0 &&
                            commandEmpDelRules.ExecuteNonQuery() == 0
                        )
                    {
                        MessageBox.Show("Сотрудник удалён");
                    }

                    database.closeConnection();
                }

                if (rowState == RowState.Modified)
                {
                    var userId = dgv.Rows[i].Cells[0].Value.ToString();
                    var userName = dgv.Rows[i].Cells[1].Value.ToString();
                    var userSurname = dgv.Rows[i].Cells[2].Value.ToString();
                    var userPatronymic = dgv.Rows[i].Cells[3].Value.ToString();
                    var userNumber = dgv.Rows[i].Cells[4].Value.ToString();

                    string query =
                        $"update [dbo].[Users] set [u_name] = '{userName}', [u_phoneNumber] = '{userNumber}', [u_surname] = '{userSurname}', [u_patronymic] = '{userPatronymic}' where [id_pk_user] = {userId};";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        static public void Clients(DataGridView dgv, Database database)
        {
            database.openConnection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var rowState = (RowState)dgv.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Modified)
                {
                    var userId = dgv.Rows[i].Cells[0].Value.ToString();
                    var userName = dgv.Rows[i].Cells[1].Value.ToString();
                    var userSurname = dgv.Rows[i].Cells[2].Value.ToString();
                    var userPatronymic = dgv.Rows[i].Cells[3].Value.ToString();
                    var userNumber = dgv.Rows[i].Cells[4].Value.ToString();

                    string query =
                        $"update [dbo].[Users] set [u_name] = '{userName}', [u_phoneNumber] = '{userNumber}', [u_surname] = '{userSurname}', [u_patronymic] = '{userPatronymic}' where [id_pk_user] = {userId};";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        static public void Organizations(DataGridView dgv, Database database)
        {
            database.openConnection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var rowState = (RowState)dgv.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Modified)
                {
                    var orgId = dgv.Rows[i].Cells[0].Value.ToString();
                    var orgName = dgv.Rows[i].Cells[1].Value.ToString();
                    var orgClient = dgv.Rows[i].Cells[2].Value.ToString();
                    var orgNum = dgv.Rows[i].Cells[3].Value.ToString();
                    var orgMail = dgv.Rows[i].Cells[4].Value.ToString();

                    string query =
                        $"EXEC UpdateOrganization {orgId}, '{orgName}', '{orgClient}', '{orgNum}', '{orgMail}';";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();
                }
            }

            database.closeConnection();
        }

        static public void Vacancys(DataGridView dgv, Database database)
        {
            database.openConnection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var rowState = (RowState)dgv.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);

                    var deleteClientQuery = $"EXEC DeleteVacancy {id}";
                    SqlCommand commandEmpDel = new SqlCommand(deleteClientQuery, database.getConnection());
                    commandEmpDel.ExecuteNonQuery();

                    MessageBox.Show("Вакансия удалена");
                }

                if (rowState == RowState.Modified)
                {
                    var vacId = dgv.Rows[i].Cells[0].Value;
                    var vacOrg = dgv.Rows[i].Cells[1].Value.ToString();
                    var vacProf = dgv.Rows[i].Cells[2].Value.ToString();
                    var vacDesc = dgv.Rows[i].Cells[3].Value.ToString();
                    var vacNumber = dgv.Rows[i].Cells[4].Value.ToString();

                    string query = $"EXEC UpdateVacancy {vacId}, '{vacProf}', '{vacOrg}', '{vacDesc}', '{vacNumber}';";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Вакансия изменена");
                }
            }

            database.closeConnection();
        }

        // TODO: сделать обновление контрактов
        static public void Contracts(DataGridView dgv, Database database)
        {
            database.openConnection();

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                var rowState = (RowState)dgv.Rows[i].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dgv.Rows[i].Cells[0].Value);

                    var deleteClientQuery = $"EXEC DeleteVacancy {id}";
                    SqlCommand commandEmpDel = new SqlCommand(deleteClientQuery, database.getConnection());
                    commandEmpDel.ExecuteNonQuery();

                    MessageBox.Show("Вакансия удалена");
                }

                if (rowState == RowState.Modified)
                {
                    var vacId = dgv.Rows[i].Cells[0].Value;
                    var vacOrg = dgv.Rows[i].Cells[1].Value.ToString();
                    var vacProf = dgv.Rows[i].Cells[2].Value.ToString();
                    var vacDesc = dgv.Rows[i].Cells[3].Value.ToString();
                    var vacNumber = dgv.Rows[i].Cells[4].Value.ToString();

                    string query = $"EXEC UpdateVacancy {vacId}, '{vacProf}', '{vacOrg}', '{vacDesc}', '{vacNumber}';";
                    SqlCommand command = new SqlCommand(query, database.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Вакансия изменена");
                }
            }

            database.closeConnection();
        }

        // TODO: сделать обновление откликов
        static public void Responses(DataGridView dgv, Database database)
        {

        }
    }
}
