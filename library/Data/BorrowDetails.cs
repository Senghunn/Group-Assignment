using library.Entity;
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
    public class BorrowDetails
    {
        public static DataTable Get(int borrowid)
        {
            OracleCommand command = new OracleCommand("BorrowDetailGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_BorrowId", borrowid);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);


            return table;
        }
        public static void Add(BorrowDetail borrowdetail)
        {
            try
            {
                OracleCommand command = new OracleCommand("BorrowDetailAdd", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_BorrowId", OracleDbType.Int32).Value = borrowdetail.BorrowId;
                command.Parameters.Add("P_BookId", OracleDbType.Int32).Value = borrowdetail.BookId;
                command.Parameters.Add("P_Note", OracleDbType.Varchar2).Value = borrowdetail.Note;
                command.Parameters.Add("P_IsReturn", OracleDbType.Int32).Value = borrowdetail.IsReturn;
                command.Parameters.Add("P_ReturnDate", OracleDbType.Date).Value = borrowdetail.ReturnDate;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Update(BorrowDetail borrowdetail)
        {
            try
            {
                OracleCommand command = new OracleCommand("BorrowDetailUpdate", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_BorrowDetailId", borrowdetail.BorrowDetailId);
                command.Parameters.Add("P_BorrowId", OracleDbType.Int32).Value = borrowdetail.BorrowId;
                command.Parameters.Add("P_BookId", OracleDbType.Int32).Value = borrowdetail.BookId;
                command.Parameters.Add("P_Note", OracleDbType.Varchar2).Value = borrowdetail.Note;
                command.Parameters.Add("P_IsReturn", OracleDbType.Int32).Value = borrowdetail.IsReturn;
                command.Parameters.Add("P_ReturnDate", OracleDbType.Date).Value = borrowdetail.ReturnDate;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int borrowid)
        {
            try
            {
                OracleCommand command = new OracleCommand("BorrowDetailDelete", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_BorrowId", OracleDbType.Int32).Value = borrowid;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
