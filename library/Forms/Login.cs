using library.Data;
using library.Entity;
using library.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library
{
    public partial class Login : Form
    {
        public static AppUser UserLogon { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DoValidation())
            {
                AppUser user = AppUsers.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                if (user == null)
                {
                    MessageBox.Show("Invalid Username  and Password, Please enter again.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FormMain formmain = new FormMain();
                // formmain.UserLogin = user;
                MessageBox.Show("Login Successfully");
                UserLogon = user;
                this.Hide();

                formmain.ShowDialog();
                this.Close();
            }
        }
        bool DoValidation()
        {
            bool result = true;
            if (txtUserName.Text.Trim() == "")
            {
                epUserName.SetError(txtUserName, "Please enter username.");
                return false;
            }

            if (txtPassword.Text.Trim() == "")
            {
                epPassword.SetError(txtPassword, "Please cannot blank,Please enter password");
            }
            return result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ChPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
