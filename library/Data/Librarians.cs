
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace library.Data
{
    public class Librarians
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("LibrarianGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("P_LibrarianId", 1);
            DataTable dt = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public static Librarian Get(int librarianid)
        {
            Librarian librarian = null;

            OracleCommand command = new OracleCommand("LibrarianGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_LibrarianId", librarianid);
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                librarian = new Librarian();
                librarian.LibrarianId = Convert.ToInt32(reader["LibrarianId"].ToString());
                //librarian.IsHidden = reader["IsHidden"].ToString();
                librarian.LibrarianCode = reader["LibrarianCode"].ToString();
                librarian.LibrarianName = reader["LibrarianName"].ToString();
                librarian.Sex = reader["Sex"].ToString();
                librarian.DoB = Convert.ToDateTime(reader["DoB"].ToString());
                librarian.PoB = reader["PoB"].ToString();
                librarian.Phone = reader["Phone"].ToString();
               
            }
            return librarian;
        }

        public static void Add(Librarian librarian)
        {
            try
            {
                OracleCommand command = new OracleCommand("LibrarianAdd", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                
                command.Parameters.Add("P_IsHidden", librarian.IsHidden);
                command.Parameters.Add("P_LibrarianCode", librarian.LibrarianCode);
                command.Parameters.Add("P_LibrarianName", librarian.LibrarianName);
                command.Parameters.Add("P_Sex", librarian.Sex.Substring(0,1));
                command.Parameters.Add("P_DoB", librarian.DoB);
                command.Parameters.Add("P_PoB", librarian.PoB);
                command.Parameters.Add("P_Phone", librarian.Phone);
               

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(Librarian librarian)
        {
            try
            {
                OracleCommand command = new OracleCommand("LibrarianUpdate", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_LibrarianId", librarian.LibrarianId);
                command.Parameters.Add("P_ishidden", librarian.IsHidden);
                command.Parameters.Add("P_LibrarianCode", librarian.LibrarianCode);
                command.Parameters.Add("P_LibrarianName", librarian.LibrarianName);
                
                command.Parameters.Add("P_Sex", librarian.Sex);
                command.Parameters.Add("P_DoB", librarian.DoB);
                command.Parameters.Add("P_PoB", librarian.PoB);
                command.Parameters.Add("P_Phone", librarian.Phone);
               

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int librarianid)
        {
            try
            {
                OracleCommand command = new OracleCommand("LibrarianDelete", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_LibrarianId", librarianid);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
