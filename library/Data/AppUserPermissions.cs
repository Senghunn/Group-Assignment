﻿using library.Entity;
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
    public class AppUserPermissions
    {
        public static DataTable Get(int userid)
        {
            OracleCommand command = new OracleCommand("APPUSERPERMISSIONGET", ConnLibrary.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("AppUserId", userid);

            OracleDataAdapter adapter = new OracleDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public static void Add(AppUserPermission permission)
        {
            try
            {
                OracleCommand command = new OracleCommand("AppUserPermissionAdd", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("P_AppUserId", OracleDbType.Varchar2).Value = permission.AppUserId;
                command.Parameters.Add("P_PermissionName", OracleDbType.Varchar2).Value = permission.PermissionName;
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
                OracleCommand command = new OracleCommand("AppUserPermissionDelete", ConnLibrary.GetConnection());
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("P_AppUserId", OracleDbType.Int32);
                command.Parameters["P_AppUserId"].Value = userid;

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
