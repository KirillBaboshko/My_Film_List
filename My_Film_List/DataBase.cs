using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace My_Film_List
{
    internal class DataBase
    {
        SQLiteConnection sqlConnection = new SQLiteConnection("Data Source=My_Film_List.db");
        public void openConnection()
        {
            if(sqlConnection.State==System.Data.ConnectionState.Closed)
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
        public SQLiteConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
