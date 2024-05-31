using library.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.Data
{
    public class Books
    {
        public static DataTable GetAll(int id)
        {
            OracleCommand command = new OracleCommand("BookGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_CatalogId", id);

            DataTable dt = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable GetAllNotReturn()
        {
            OracleCommand command = new OracleCommand("BookGetNotReturn", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            OracleDataAdapter adapter = new OracleDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public static Book Get(int bookid)
        {
            Book book = null;

            OracleCommand command = new OracleCommand("BookGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("P_BookId", bookid);
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                book = new Book();
                book.BookId = Convert.ToInt32(reader["BookId"]);
                book.BookCode = reader["BookCode"].ToString();
                book.BookDescription = reader["BookDescription"].ToString();

                book.CatalogId = Convert.ToInt32(reader["CatalogId"].ToString());


            }
            return book;
        }
        public static void Add(Book book)
        {
            try
            {
                OracleCommand command = new OracleCommand("BookAdd", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                //command.Parameters.Add("P_BookId", OracleDbType.Int32).Value = book.BookId;
                command.Parameters.Add("P_CatalogId", book.CatalogId);
                command.Parameters.Add("P_BookCode",  book.BookCode);
                command.Parameters.Add("P_BookDescription",book.BookDescription);
               

                command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void Update(Book book)
        {
            try
            {
                OracleCommand command = new OracleCommand("BookUpdate", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_BookId", OracleDbType.Int32).Value = book.BookId;
                command.Parameters.Add("P_CatalogId", OracleDbType.Int32).Value = book.CatalogId;
                command.Parameters.Add("P_BookCode", OracleDbType.Varchar2).Value = book.BookCode;
                command.Parameters.Add("P_BookDescription", OracleDbType.Varchar2).Value = book.BookDescription;

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
                OracleCommand command = new OracleCommand("BOOKDELETE", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_CatalogId",  catalogid);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
