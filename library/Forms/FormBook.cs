using library.Data;
using library.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.Forms
{
    public partial class FormBook : Form
    {
        DataTable dtCatalog, dtVbook;
        DataTable dtBook;
        AppUser user;

        BindingSource bsCatalog;
        public FormBook(AppUser user)
        {
            InitializeComponent();
            InitializeData();
            this.user = user;
        }
        void InitializeData()
        {
            LoadCatalog();
           
        }

        public void LoadCatalog()
        {
            dtCatalog = Catalogs.GetAll();
            bsCatalog = new BindingSource();
            bsCatalog.DataSource = dtCatalog;

            txtCatalogId.DataBindings.Clear();
            txtCatalogId.DataBindings.Add("Text", bsCatalog, "CatalogId");

            txtCatalogCode.DataBindings.Clear();
            txtCatalogCode.DataBindings.Add("Text", bsCatalog, "CatalogCode");

            txtCatalogName.DataBindings.Clear();
            txtCatalogName.DataBindings.Add("Text", bsCatalog, "CatalogName");

            txtIsbn.DataBindings.Clear();
            txtIsbn.DataBindings.Add("Text", bsCatalog, "Isbn");

            txtAuthorName.DataBindings.Clear();
            txtAuthorName.DataBindings.Add("Text", bsCatalog, "AuthorName");

            txtPublisher.DataBindings.Clear();
            txtPublisher.DataBindings.Add("Text", bsCatalog, "Publisher");

            txtPublishYear.DataBindings.Clear();
            txtPublishYear.DataBindings.Add("Text", bsCatalog, "PublishYear");

            txtPublishEdtion.DataBindings.Clear();
            txtPublishEdtion.DataBindings.Add("Text", bsCatalog, "PublishEdition");

            LoadBook();
        }

        public void LoadBook()
        {
            if(bsCatalog.Count <= 0)
            {
                dtBook = Books.GetAll(0);
            }
            else
            {
                DataRowView current = (DataRowView)bsCatalog.Current;
                int catalogid = Convert.ToInt32(current["CatalogId"].ToString());
                dtBook = Books.GetAll(catalogid);
            }
            dgBook.DataSource = dtBook;
            dgBook.Columns[0].Visible = false;
            dgBook.Columns[0].DataPropertyName = "BookId";
            dgBook.Columns[1].Visible = false;
            dgBook.Columns[1].DataPropertyName = "isHidden";
            dgBook.Columns[2].Visible = false;
            dgBook.Columns[2].DataPropertyName = "CatalogId";

            dgBook.Columns[3].Visible = true;
            dgBook.Columns[3].DataPropertyName = "BookCode";

            dgBook.Columns[3].Width = 250;
            dgBook.Columns[3].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgBook.Columns[3].DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);
            dgBook.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgBook.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgBook.Columns[3].HeaderText = "BookCode";
            dgBook.DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);

            dgBook.Columns[4].Visible = true;
            dgBook.Columns[4].DataPropertyName = "BookDescription";

            dgBook.Columns[4].Width = 250;
            dgBook.Columns[4].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgBook.Columns[4].DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);
            dgBook.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgBook.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgBook.Columns[4].HeaderText = "BookDescription";
            dgBook.DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgBook.EndEdit();
            if (!DoValidation())
            {
                return;
            }

            DataRowView datarow = (DataRowView)bsCatalog.Current;
            if (datarow.IsNew)
            {
                if (DoValidation())
                {
                    Catalog catalog = new Catalog();
                    catalog.CatalogCode = txtCatalogCode.Text.Trim();
                    catalog.CatalogName = txtCatalogName.Text.Trim();
                    catalog.Isbn = txtIsbn.Text.Trim();
                    catalog.AuthorName = txtAuthorName.Text.Trim(); 
                    catalog.Publisher = txtPublisher.Text.Trim();
                    catalog.PublishYear = txtPublishYear.Text.Trim();
                    catalog.PublishEdition = txtPublishEdtion.Text.Trim();

                    int catalogid = Catalogs.Add(catalog);

                    if(catalogid > 0)
                    {
                        dtBook.Columns["CatalogId"].DefaultValue = catalogid;
                        //dgBook.Refresh();
                        dtBook.AcceptChanges();
                        
                        foreach(DataRow row in dtBook.Rows)
                        {
                            Book book = new Book();
                            book.CatalogId = catalogid;


                            book.BookCode = row["BookCode"].ToString();
                            book.BookDescription = row["BookDescription"].ToString();
                            Books.Add(book);
                        }
                    }
                    MessageBox.Show("Book has added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCatalog();
                    btnSave.Enabled = false;

                }
            }
            else
            {
                if (DoValidation())
                {
                    Catalog catalog = new Catalog();
                    catalog.CatalogId = Convert.ToInt32(txtCatalogId.Text);
                    catalog.CatalogCode = txtCatalogCode.Text.Trim();
                    catalog.CatalogName = txtCatalogName.Text.Trim();
                    catalog.Isbn = txtIsbn.Text.Trim();
                    catalog.AuthorName = txtAuthorName.Text.Trim();
                    catalog.Publisher = txtPublisher.Text.Trim();
                    catalog.PublishYear = txtPublishYear.Text.Trim();
                    catalog.PublishEdition = txtPublishEdtion.Text.Trim();
                    Catalogs.Update(catalog);

                    Books.Delete(catalog.CatalogId);
                    dgBook.Refresh();
                    dtBook.AcceptChanges();

                    foreach (DataRow row in dtBook.Rows)
                    {
                        Book book = new Book();
                        book.CatalogId = catalog.CatalogId;


                        book.BookCode = row["BookCode"].ToString();
                        book.BookDescription = row["BookDescription"].ToString();

                        Books.Add(book);
                    }

                    MessageBox.Show("Book has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCatalog();

                }

            }
              
        }
        bool DoValidation()
        {
            bool result = true;
            if (txtCatalogName.Text.Trim() == "")
            {
                epCatalogName.SetError(txtCatalogName, "Please Enter Catalog Name");
                result = false;
            }
            return result;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsCatalog.CancelEdit();
            bsCatalog.MovePrevious();
            LoadBook();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsCatalog.CancelEdit();
            bsCatalog.MoveNext();
            LoadBook();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bsCatalog.AddNew();
            dtBook.Rows.Clear();
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsCatalog.Count <= 0)
            {
                return;
            }

            DataRowView datarow = (DataRowView)bsCatalog.Current;
            if (datarow.IsNew)
            {
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }
            Catalogs.Delete(Convert.ToInt32(txtCatalogId.Text));

            MessageBox.Show("Book has deleted successfully");

            InitializeData();
        }

        private void dgBook_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgBook.DefaultCellStyle.BackColor))
                {
                    e.Graphics.FillRectangle(b, e.CellBounds);
                }
                using (Pen p = new Pen(Brushes.Black))
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    p.Color = Color.FromArgb(33, 37, 41);

                    e.Graphics.DrawLine(p, new Point(0, e.CellBounds.Bottom - 1), new Point(e.CellBounds.Right, e.CellBounds.Bottom - 1));
                    e.Graphics.DrawLine(p, new Point(0, 0), new Point(e.CellBounds.Right, 0));
                }
                e.PaintContent(e.ClipBounds);
            }
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            DataTable dtUserPermission = AppUserPermissions.Get(user.AppUserId);

            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "BookCreate")
                {
                    btnNew.Visible = true;
                }

                if (row["UserPermission"].ToString() == "BookModify")
                {
                    btnSave.Enabled = true;
                }
                
                if (row["UserPermission"].ToString() == "BookDelete")
                {
                    btnDelete.Visible = true;
                }


            }
            txtCatalogId.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtPublishYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
