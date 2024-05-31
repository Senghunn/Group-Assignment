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
    internal class Customers
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("CustomerGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            
            DataTable dt = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public static Customer Get(int customerid)
        {
            Customer customer = null;

            OracleCommand command = new OracleCommand("CustomerGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CustomerId", customerid);
            OracleDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                customer = new Customer();
                customer.CustomerId = Convert.ToInt32(reader["CustomerId"].ToString());
                
                customer.CustomerCode = reader["CustomerCode"].ToString();
                customer.CustomerTypeId = Convert.ToInt32(reader["CustomerTypeId"]);
                customer.CustomerName = reader["CustomerName"].ToString();
                customer.Sex = reader["Sex"].ToString();
                customer.DoB = Convert.ToDateTime(reader["DoB"].ToString());
                customer.PoB = reader["PoB"].ToString();
                customer.Phone = reader["Phone"].ToString();
                customer.Address = reader["Address"].ToString();

            }
            return customer;
        }

        public static void Add(Customer customer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerAdd", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_IsHidden", customer.IsHidden);
                command.Parameters.Add("P_CustomerCode", customer.CustomerCode);
                command.Parameters.Add("P_CustomerTypeId",customer.CustomerTypeId);
                command.Parameters.Add("P_CustomerName", customer.CustomerName);
                command.Parameters.Add("P_Sex", customer.Sex.Substring(0, 1));
                command.Parameters.Add("P_DoB", customer.DoB);
                command.Parameters.Add("P_PoB", customer.PoB);
                command.Parameters.Add("P_Phone", customer.Phone);
                command.Parameters.Add("P_Address", customer.Address);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Update(Customer customer)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerUpdate", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CustomerId", customer.CustomerId);
                command.Parameters.Add("P_ishidden", customer.IsHidden);
                command.Parameters.Add("P_CustomerCode", customer.CustomerCode);
                command.Parameters.Add("P_CustomerTypeId", customer.CustomerTypeId);
                command.Parameters.Add("P_CustomerName", customer.CustomerName);
                command.Parameters.Add("P_Sex", customer.Sex.Substring(0, 1));
                command.Parameters.Add("P_DoB", customer.DoB);
                command.Parameters.Add("P_PoB", customer.PoB);
                command.Parameters.Add("P_Phone", customer.Phone);
                command.Parameters.Add("P_Address", customer.Address);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void Delete(int customerid)
        {
            try
            {
                OracleCommand command = new OracleCommand("CustomerDelete", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_CustomerId", customerid);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
