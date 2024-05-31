
using Oracle.ManagedDataAccess.Client;

namespace library.Data
{
    public class ConnLibrary
    {
        static OracleConnection con;

        public static void OpenConnection()
        {
            if(con == null)
            {
                con = new OracleConnection();
                con.ConnectionString = "Data Source=localhost:1521/XEPDB1;User Id = Library; Password = 123; ";
                con.Open();
            }

           
        }

        public static OracleConnection GetConnection()
        {

            if (con == null)
            {
                OpenConnection();

            }

            return con;
        }
        public static void CloseConnection()
        {
            if (con != null)
            {
                con.Close();
            }
            con = null;
        }
        
    }
}
