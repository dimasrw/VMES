using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace VMES.Contragent.DataModel
{
    public sealed class ConnectionSingleton
    {
        private static SqlConnection connection = null;
        private string connectionString = String.Empty;
         
        public static SqlConnection Connection
        {
            get {
                if (connection == null)
                {
                connection = new SqlConnection();
                connection.ConnectionString= ConfigurationManager.ConnectionStrings["CtrConnectionString"].ConnectionString;
                }
                return connection;
            }
        }

        public static void Open()
        {
            if (!(connection == null))
            {
                connection.Open();
            }
        }

        public static void Close()
        {
            if ((!(connection == null))&&(connection.State==ConnectionState.Open))
            {
                connection.Close();
            }
        }
    }
}
