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
    public class CustomerTypes
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("CustomerTypeGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.Add("P_LibrarianId", 1);
            DataTable dt = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public static CustomerType Get(int customertypeid)
        {
            CustomerType customertype = null;

            OracleCommand command = new OracleCommand("CustomerTypeGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CustomerTypeId", customertypeid);
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                customertype = new CustomerType();
                customertype.CustomerTypeId = Convert.ToInt32(reader["CustomerTypeId"].ToString());

                customertype.CustomerTypename = reader["CustomerTypeName"].ToString();

            }
            return customertype;
        }

        public static void Add(CustomerType customertype)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerTypeAdd", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                //command.Parameters.Add("P_IsHidden", librarian.IsHidden);
                //command.Parameters.Add("P_LibrarianCode", customertype.LibrarianCode);
                command.Parameters.Add("P_CustomerTypeName", customertype.CustomerTypename);
                


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(CustomerType customertype)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerTypeUpdate", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CustomerTypeId", customertype.CustomerTypeId);
                //command.Parameters.Add("P_ishidden", librarian.IsHidden);
               
                command.Parameters.Add("P_CustomerTypeName", customertype.CustomerTypename);



                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int customertypeid)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerTypeDelete", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_CustomerTypeId", customertypeid);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
