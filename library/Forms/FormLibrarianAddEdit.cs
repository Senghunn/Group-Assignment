using library.Data;
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
    public partial class FormLibrarianAddEdit : Form
    {
        Librarian librarian;
        bool isnew;
        public FormLibrarianAddEdit(Librarian librarian)
        {
            InitializeComponent();

            if(librarian == null )
            {
                this.librarian = new Librarian();
                lblTitle.Text = "New Librarian";

                isnew = true;
                txtLibName.Focus();

            }
            else
            {
                lblTitle.Text = "Edit Librarian";
                isnew = false;
                this.librarian = librarian;
                InitializeData();
                txtLibName.Focus();
            }
        }
        void InitializeData()
        {

            
            txtLibCode.Text = librarian.LibrarianCode;
            txtLibName.Text = librarian.LibrarianName;
            dtpDoB.Value = librarian.DoB;
            txtPhone.Text = librarian.Phone;
            txtPoB.Text = librarian.PoB;
            txtSex.Text = librarian.Sex;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        int librarianId = 0;
        private void FormLibrarianAddEdit_Load(object sender, EventArgs e)
        {
            librarianId = librarian.LibrarianId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Dovalidation())
            {
                if (isnew)
                {
                    librarian = new Librarian();
                    
                    librarian.LibrarianCode = txtLibCode.Text;
                    librarian.LibrarianName = txtLibName.Text;
                    librarian.Sex = txtSex.Text;
                    librarian.DoB = dtpDoB.Value;
                    
                    librarian.PoB = txtPoB.Text;
                    librarian.Phone = txtPhone.Text;

                    Librarians.Add(librarian);

                }
                else
                {
                    librarian = new Librarian();
                    librarian.LibrarianId = librarianId;
                    librarian.IsHidden = 0;
                    librarian.LibrarianCode = txtLibCode.Text;
                    librarian.LibrarianName = txtLibName.Text;
                    librarian.Sex = txtSex.Text.Substring(0,1);
                    librarian.DoB = dtpDoB.Value;
                    
                    librarian.PoB = txtPoB.Text;
                    librarian.Phone = txtPhone.Text;

                    Librarians.Update(librarian);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool Dovalidation()
        {
            bool result = true;
            if (txtLibName.Text.Trim() == "")
            {
                epLibrarianName.SetError(txtLibName, "Please Enter Librarian Name");
                result = false;
            }
            return result;
        }

    }

}
