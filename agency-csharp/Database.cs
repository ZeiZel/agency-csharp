using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace agency_csharp
{
    class Database
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=ZEIZEL;Initial Catalog=Agency;Persist Security Info=True;User ID=guest;Password=guest;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True");

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return sqlConnection;
        }
    }
}
