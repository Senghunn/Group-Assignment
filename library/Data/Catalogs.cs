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
    public class Catalogs
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("CatalogGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
        public static Catalog Get(int catalogid)
        {
            Catalog catalog = null;
            OracleCommand command = new OracleCommand("CATALOGGET", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_CatalogId", catalogid);

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                catalog = new Catalog();

                catalog.CatalogId = Convert.ToInt32(reader["CatalogId"]);
                catalog.CatalogCode = reader["CatalogCode"].ToString();
                catalog.CatalogName = reader["CatalogName"].ToString();
                catalog.Isbn = reader["Isbn"].ToString();
                catalog.AuthorName = reader["AuthorName"].ToString();
                catalog.Publisher = reader["Publisher"].ToString();
                catalog.PublishYear = reader["PublishYear"].ToString();
                catalog.PublishEdition = reader["PublishEdition"].ToString() ;

            }
            return catalog;
        }
        //public static int Add(Catalog catalog)
        //{
        //    int catalogid = 0;

        //    OracleCommand command = new OracleCommand("CatalogAdd", ConnLibrary.GetConnection());
        //    command.CommandType = CommandType.StoredProcedure;

        //    command.Parameters.Add("P_CatalogCode", catalog.CatalogCode);
        //    command.Parameters.Add("P_CatalogName", catalog.CatalogName);
        //    command.Parameters.Add("P_Isbn", catalog.Isbn);
        //    command.Parameters.Add("P_AuthorName", catalog.AuthorName);
        //    command.Parameters.Add("P_Publishser", catalog.Publisher);
        //    command.Parameters.Add("P_PublishYear", catalog.PublishYear);
        //    command.Parameters.Add("P_PublishEdition", catalog.PublishEdition);
        //    command.Parameters.Add("P_CatalogId", OracleDbType.Int32).Direction = ParameterDirection.Output;

        //    command.ExecuteNonQuery();
        //    catalogid = Convert.ToInt32(command.Parameters["P_CatalogId"].Value.ToString());

        //    return catalogid;

        //}
        public static int Add(Catalog catalog)
        {
            int catalogid = 0;

            OracleCommand command = new OracleCommand("CatalogAdd", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_ishidden", catalog.IsHidden);
            command.Parameters.Add("P_catalogcode", catalog.CatalogCode);
            command.Parameters.Add("P_catalogname", catalog.CatalogName);
            command.Parameters.Add("P_isbn", catalog.Isbn);
            command.Parameters.Add("P_authorname", catalog.AuthorName);
            command.Parameters.Add("P_publisher", catalog.Publisher);
            command.Parameters.Add("P_publishyear", catalog.PublishYear);
            command.Parameters.Add("P_publishedition", catalog.PublishEdition);
            command.Parameters.Add("P_CatalogId", OracleDbType.Int32).Direction = ParameterDirection.Output;

            command.ExecuteNonQuery();
            catalogid = Convert.ToInt32(command.Parameters["P_CatalogId"].Value.ToString());

            return catalogid;
        }




        public static void Update(Catalog catalog)
        {
            try
            {
                OracleCommand command = new OracleCommand("CATALOGUPDATE", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_catalogid", catalog.CatalogId);
                command.Parameters.Add("P_catalogcode", catalog.CatalogCode);
                command.Parameters.Add("P_catalogname", catalog.CatalogName);
                command.Parameters.Add("P_isbn", catalog.Isbn);
                command.Parameters.Add("P_authorname", catalog.AuthorName);
                command.Parameters.Add("P_publisher", catalog.Publisher);
                command.Parameters.Add("P_publishyear", catalog.PublishYear);
                command.Parameters.Add("P_publishedition", catalog.PublishEdition);

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Delete(int catalogid)
        {
            try
            {
                OracleCommand command = new OracleCommand("CatalogDelete", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CatalogId", catalogid);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
