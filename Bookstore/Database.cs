using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Database
    {
        OleDbConnection connection;

        public Database()
        {
            this.connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='C:\Users\Djordjevic\Desktop\Knjizara.accdb'";
        }
        public void OpenConnection()
        {
            if (connection != null)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection != null)
            {
                connection.Close();
            }
        }
        public OleDbConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }
    }
}
