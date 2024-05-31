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
    public class Borrows
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("BorrowGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public static Borrow Get(int borrowid)
        {
            Borrow borrow = null;
            OracleCommand command = new OracleCommand("BorrowGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_BorrowId", borrowid);

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                borrow = new Borrow();

                borrow.BorrowId = Convert.ToInt32(reader["BorrowId"]);
                //borrow.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                borrow.LibrarianId = Convert.ToInt32(reader["LibrarianId"]);
                borrow.BorrowDate = Convert.ToDateTime(reader["BorrowDate"]);
                borrow.BorrowCode = reader["BorrowCode"].ToString();
                borrow.DepositAmount = Convert.ToInt32(reader["DepositAmount"]);
                borrow.DueDate = Convert.ToDateTime(reader["DueDate"]);
                borrow.FineAmount = Convert.ToDouble(reader["FineAmount"]);
                borrow.MeMo = reader["MeMo"].ToString();



                //if saleRep is not null it take value from table
                if (!Convert.IsDBNull(reader["CustomerId"]))
                {
                    borrow.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                }

                

            }
            return borrow;
        }
        public static int Add(Borrow borrow)
        {
            int borrowid = 0;

            OracleCommand command = new OracleCommand("BorrowAdd", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CustomerId", borrow.CustomerId);
            command.Parameters.Add("P_LibrarianId", borrow.LibrarianId);
            command.Parameters.Add("P_BorrowDate", borrow.BorrowDate);
            command.Parameters.Add("P_BorrowCode", borrow.BorrowCode);
            command.Parameters.Add("P_DepositAmount", borrow.DepositAmount);
            command.Parameters.Add("P_DueDate", borrow.DueDate);
            command.Parameters.Add("P_FineAmount", borrow.FineAmount);
            command.Parameters.Add("P_MeMo", borrow.MeMo);
            command.Parameters.Add("P_borrowId", OracleDbType.Int32).Direction= ParameterDirection.Output;

            command.ExecuteNonQuery();
            borrowid = Convert.ToInt32(command.Parameters["P_borrowId"].Value.ToString());

            return borrowid;

        }
        public static void Update(Borrow borrow)
        {
            try
            {
                OracleCommand command = new OracleCommand("BorrowUpdate", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_BorrowId", borrow.BorrowId);
                command.Parameters.Add("P_ishidden", borrow.IsHidden);
                command.Parameters.Add("P_CustomerId", borrow.CustomerId);
                command.Parameters.Add("P_LibrarianId", borrow.LibrarianId);
                command.Parameters.Add("P_BorrowDate", borrow.BorrowDate);
                command.Parameters.Add("P_BorrowCode", borrow.BorrowCode);
                command.Parameters.Add("P_DepositAmount", borrow.DepositAmount);
                command.Parameters.Add("P_DueDate", borrow.DueDate);
                command.Parameters.Add("P_FineAmount", borrow.FineAmount);
                command.Parameters.Add("P_MeMo", borrow.MeMo);

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
                OracleCommand command = new OracleCommand("BorrowDelete", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_BorrowId", borrowid);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
