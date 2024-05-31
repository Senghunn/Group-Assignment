using library.Data;
using library.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.Forms
{
    public partial class FormLibrarian : Form
    {
        DataTable dtlibrarian;
        AppUser user;
        public FormLibrarian(AppUser user)
        {
            InitializeComponent();
            InitializeData();
            this.user = user;
        }

        public void InitializeData()
        {
            dtlibrarian = new DataTable();
            dtlibrarian = Librarians.GetAll();
            dglibrarian.DataSource = dtlibrarian;
            dglibrarian.Columns[0].Visible = false;

            dglibrarian.Columns[3].HeaderText = "Librarian Name";
            dglibrarian.Columns[3].Width = 200;
            dglibrarian.Columns[3].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dglibrarian.Columns[3].DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);
            dglibrarian.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dglibrarian.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dglibrarian.Columns[3].Visible = true;
            dglibrarian.DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);

            dglibrarian.Columns[1].Visible = false;
            dglibrarian.Columns[2].Visible = false;
            dglibrarian.Columns[4].Visible = false;
            dglibrarian.Columns[5].Visible = false;
            dglibrarian.Columns[6].Visible = false;
            dglibrarian.Columns[7].Visible = false;


        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormLibrarianAddEdit librarianAddEdit = new FormLibrarianAddEdit(null);

            if (librarianAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }
        private void FormLibrarian_Load(object sender, EventArgs e)
        {
            DataTable dtUserPermission = AppUserPermissions.Get(user.AppUserId);

            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "LibrarianCreate")
                {
                    btnNew.Visible = true;
                }
                if (row["UserPermission"].ToString() == "LibrarainModify")
                {
                    btnEdit.Visible = true;
                }
                if (row["UserPermission"].ToString() == "LibrarianDelete")
                {
                    btnDelete.Visible = true;
                }
                


            }
            InitializeData();
        }

        private void dglibrarian_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if(e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dglibrarian.DefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(b,e.CellBounds);
                }
                using (Pen p = new Pen(Brushes.Black))
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    p.Color = Color.FromArgb(33, 37, 41);
                    e.Graphics.DrawLine(p,new Point(0,e.CellBounds.Bottom-1),new Point(e.CellBounds.Right, e.CellBounds.Bottom-1));
                    e.Graphics.DrawLine(p, new Point(0, 0), new Point(e.CellBounds.Right, 0));
                }
                e.PaintContent(e.ClipBounds);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dglibrarian.SelectedRows.Count > 0)
            {
                librarianid = Convert.ToInt32(dglibrarian.SelectedRows[0].Cells[0].Value.ToString());
                Librarian librarian = Librarians.Get(librarianid);

                FormLibrarianAddEdit formLibrarianAddEdit = new FormLibrarianAddEdit(librarian);

                if(formLibrarianAddEdit.ShowDialog() == DialogResult.OK)
                {
                    InitializeData();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(this, "Confirmation!\n Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                int librarianid = Convert.ToInt32(dglibrarian.SelectedRows[0].Cells["LibrarianId"].Value.ToString());

                Librarians.Delete(librarianid);

                MessageBox.Show("Librarian had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();
            }
        }
         int librarianid = 0;
        private void dglibrarian_SelectionChanged(object sender, EventArgs e)
        {
            if (dglibrarian.SelectedRows.Count > 0)
            {
                librarianid = Convert.ToInt32(dglibrarian.SelectedRows[0].Cells[0].Value.ToString());
                Librarian librarian = Librarians.Get(librarianid);

                if (librarian != null)
                {
                   
                    txtLibCode.Text = librarian.LibrarianCode;
                    txtLibName.Text = librarian.LibrarianName;
                    txtSex.Text = librarian.Sex;
                    dtpDoB.Value = librarian.DoB;

                    txtPoB.Text = librarian.PoB;
                    txtPhone.Text = librarian.Phone;
                }



            }
        }
    }
}
