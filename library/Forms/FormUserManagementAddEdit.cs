using library.Data;
using library.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.Forms
{
    public partial class FormUserManagementAddEdit : Form
    {
        AppUser _user;
        bool newuser;
        public FormUserManagementAddEdit(AppUser user)
        {
            
            InitializeComponent();
            if (user == null)
            {
                this._user = new AppUser();

                lblTitle.Text = "New User";
                this.newuser = true;
                txtUserName.Focus();
            }
            else
            {
                this._user = user;
                this.newuser = false;
                lblTitle.Text = "Edit User";
                InitializeData();
                txtUserName.Focus();

            }
        }
        void InitializeData()
        {
            txtUserName.Text = _user.UserName;
            txtPassword.Text = _user.Password;
            txtConfirm.Text = _user.Password;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Dovalidation())
            {
                _user.UserName = txtUserName.Text.Trim();
                _user.Password = txtPassword.Text.Trim();
                if (newuser)
                    AppUsers.Add(_user);
                else
                    AppUsers.Update(_user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool Dovalidation()
        {
            bool result = true;
            if (txtUserName.Text.Trim() == "")
            {
                epUserName.SetError(txtUserName, "Please enter User Name");
                result = false;
            }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
