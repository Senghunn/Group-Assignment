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
    public partial class FormMain : Form
    {
        FormLibrarian librarian;
        FormCustomer customer;
        FormCustomerType customertype;
        FormBook book;
        FormBorrow borrowbook;
        AppUser user;
        FormUserManagement userManagement;

        public FormMain()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void mCustomers_Click_1(object sender, EventArgs e)
        {
            mCustomerSub.Visible =! mCustomerSub.Visible;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerlist_Click(object sender, EventArgs e)
        {
            if(customer == null)
            {
                customer = new FormCustomer(user);
                customer.TopLevel = false;
                customer.WindowState = FormWindowState.Maximized;
                customer.Dock = DockStyle.Fill;
                customer.FormBorderStyle = FormBorderStyle.None;
                pnMain.Controls.Add(customer);
                customer.Show();
                customer.BringToFront();
               
            }
            else
            {

                customer.BringToFront();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mLibrarian_Click(object sender, EventArgs e)
        {

            if (librarian == null)
            {
                librarian = new FormLibrarian(user);
                librarian.TopLevel = false;
                librarian.WindowState = FormWindowState.Maximized;
                librarian.Dock = DockStyle.Fill;
                librarian.FormBorderStyle = FormBorderStyle.None;
                pnMain.Controls.Add(librarian);
                librarian.Show();
                librarian.BringToFront();

            }
            else
            {

                librarian.BringToFront();
            }
        }

       

        private void mBorrow_Click(object sender, EventArgs e)
        {
            if (borrowbook == null)
            {
                borrowbook = new FormBorrow(user);
                borrowbook.TopLevel = false;
                borrowbook.WindowState = FormWindowState.Maximized;
                borrowbook.Dock = DockStyle.Fill;
                borrowbook.FormBorderStyle = FormBorderStyle.None;
                pnMain.Controls.Add(borrowbook);
                borrowbook.Show();
                borrowbook.BringToFront();

            }
            else
            {

                borrowbook.BringToFront();
            }
        }

        private void mcustomertype_Click(object sender, EventArgs e)
        {

            if (customertype == null)
            {
                customertype = new FormCustomerType(user);
                customertype.TopLevel = false;
                customertype.WindowState = FormWindowState.Maximized;
                customertype.Dock = DockStyle.Fill;
                customertype.FormBorderStyle = FormBorderStyle.None;
                pnMain.Controls.Add(customertype);
                customertype.Show();
                customertype.BringToFront();
            }
            else
            {

                customertype.BringToFront();
            }
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mBook_Click(object sender, EventArgs e)
        {
            if (book == null)
            {
                book = new FormBook(user);
                book.TopLevel = false;
                book.WindowState = FormWindowState.Maximized;
                book.Dock = DockStyle.Fill;
                book.FormBorderStyle = FormBorderStyle.None;
                pnMain.Controls.Add(book);
                book.Show();
                book.BringToFront();

            }
            else
            {

                book.BringToFront();
            }
        }

        private void mUserManagement_Click(object sender, EventArgs e)
        {
            if (userManagement == null)
            {
                userManagement = new FormUserManagement(user);
                userManagement.TopLevel = false;
                userManagement.WindowState = FormWindowState.Maximized;
                userManagement.Dock = DockStyle.Fill;
                userManagement.FormBorderStyle = FormBorderStyle.None;
                pnMain.Controls.Add(userManagement);
                userManagement.Show();
                userManagement.BringToFront();

            }
            else
            {

                userManagement.BringToFront();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Login formlogin = new Login();
            //if (formlogin.ShowDialog() != DialogResult.OK)
            //{
            //    Application.Exit();
            //}
            //else
            //{
            user = Login.UserLogon;
            DataTable dtUserPermission = AppUserPermissions.Get(user.AppUserId);

            if (user.IsAdmin)
            {
                pUser.Visible = true;
            }
            else
            {
                pUser.Visible = false;
            }

            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["USERPERMISSION"].ToString() == "CustomerView")
                {
                    mcustomerlist.Visible = true;
                }
                if (row["USERPERMISSION"].ToString() == "CustomerTypeView")
                {
                    mcustomertype.Visible = true;
                }
                if (row["USERPERMISSION"].ToString() == "LibrarianView")
                {
                    pLibrarian.Visible = true;
                }
                if (row["USERPERMISSION"].ToString() == "BookView")
                {
                    pBook.Visible = true;
                }
                if (row["USERPERMISSION"].ToString() == "BorrowView")
                {
                    pBorrow.Visible = true;
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            this.Hide();
        }
    }
}
