using library.Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace library.Data
{
    public class AppUsers
    {
        public static DataTable GetAll()
        {
            OracleCommand command = new OracleCommand("AppUserGet", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }
    public static AppUser Get(int id)
    {
        AppUser appuser = null;

        OracleCommand command = new OracleCommand("AppUserGet", ConnLibrary.GetConnection());
        command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("AppUserId", id);
        OracleDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            appuser = new AppUser();
            appuser.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
            appuser.UserName = reader["UserName"].ToString();
            appuser.Password = reader["Password"].ToString();
            appuser.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
        }
        return appuser;

    }
    public static void Add(AppUser user)
    {
        try
        {
            OracleCommand command = new OracleCommand("AppUserAdd", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_UserName", user.UserName);
            command.Parameters.Add("P_UserPassword", user.Password);

            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void Update(AppUser user)
    {
        try
        {
            OracleCommand command = new OracleCommand("AppUserUpdate", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("P_AppUserId", user.AppUserId);
            command.Parameters.Add("P_UserName", user.UserName);
            command.Parameters.Add("P_UserPassword", user.Password);

            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static void Delete(int userid)
    {
        try
        {
            OracleCommand cmd = new OracleCommand("AppUserDelete", ConnLibrary.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("P_AppUserId", OracleDbType.Int32).Value = userid;
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public static AppUser Login(string username, string password)
    {
        AppUser appuser = null;
        OracleCommand command = new OracleCommand("AppUserLogin", ConnLibrary.GetConnection());
        command.CommandType = CommandType.StoredProcedure;
        command.Parameters.Add("P_UserName", username);
        command.Parameters.Add("P_UserPassword", password);

        OracleDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            appuser = new AppUser();
            appuser.AppUserId = Convert.ToInt32(reader["AppUserId"].ToString());
            appuser.UserName = reader["UserName"].ToString();
            appuser.Password = reader["Password"].ToString();

            appuser.IsAdmin = Convert.ToBoolean(reader["IsAdmin"]);
        }

        return appuser;

    }

    }

   

}
