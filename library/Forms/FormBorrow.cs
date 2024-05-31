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
    public partial class FormBorrow : Form
    {
        DataTable dtBorrow, dtVBorrow;
      
        DataTable dtBorrowDetail;

        BindingSource bsBorrow;
        AppUser user;
        public FormBorrow(AppUser user)
        {
            InitializeComponent();
            InitializeData();
            this.user = user;
        }
        void InitializeData()
        {
            LoadBorrow();
            LoadCustomer();
            LoadLibrarian();
        }
        void LoadBorrow()
        {
            dtBorrow = Borrows.GetAll();
            bsBorrow = new BindingSource();
            bsBorrow.DataSource = dtBorrow;

            txtBorrowId.DataBindings.Clear();
            txtBorrowId.DataBindings.Add("Text", bsBorrow, "BorrowId");

            dtpBorrowDate.DataBindings.Clear();
            dtpBorrowDate.DataBindings.Add("Text", bsBorrow, "BorrowDate", true);

            dtpDueDate.DataBindings.Clear();
            dtpDueDate.DataBindings.Add("Text", bsBorrow, "DueDate", true);

            txtBorrowCode.DataBindings.Clear();
            txtBorrowCode.DataBindings.Add("Text", bsBorrow, "BorrowCode");

            cboCustomerName.DataBindings.Clear();
            cboCustomerName.DataBindings.Add(new Binding("SelectedValue", bsBorrow, "CustomerId"));

            cboLibrarianName.DataBindings.Clear();
            cboLibrarianName.DataBindings.Add(new Binding("SelectedValue", bsBorrow, "LibrarianId"));

            txtDepositAmount.DataBindings.Clear();
            txtDepositAmount.DataBindings.Add("Text", bsBorrow, "DepositAmount");

            txtFineAmount.DataBindings.Clear();
            txtFineAmount.DataBindings.Add("Text", bsBorrow, "FineAmount");


            txtMemo.DataBindings.Clear();
            txtMemo.DataBindings.Add("Text", bsBorrow, "MeMo");



            LoadBorrowDetail();

        }
        int num = 0;
        void LoadBorrowDetail()
        {
            if (bsBorrow.Count <= 0)
            {
                dtBorrowDetail = BorrowDetails.Get(0);
            }
            else
            {
                DataRowView current = (DataRowView)bsBorrow.Current;
                int saleid = Convert.ToInt32(current["BorrowId"].ToString());
                dtBorrowDetail = BorrowDetails.Get(saleid);
            }
            num = 0;
            SetProperty();
            
            dgBorrowDetail.DataSource = dtBorrowDetail;
            

        }

        private void SetProperty()
        {

            dgBorrowDetail.Columns[0].Visible = false;
            dgBorrowDetail.Columns[0].DataPropertyName = "BorrowDetailId";

            dgBorrowDetail.Columns[1].Visible = false;
            dgBorrowDetail.Columns[1].DataPropertyName = "BorrowId";

            dgBorrowDetail.Columns[2].Visible = true;
            dgBorrowDetail.Columns[2].HeaderText = "Book";
            dgBorrowDetail.Columns[2].Width = 250;
            dgBorrowDetail.Columns[2].DefaultCellStyle.Font = new Font("Poppins", 11);
            dgBorrowDetail.Columns[2].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgBorrowDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgBorrowDetail.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgBorrowDetail.Columns[2].DataPropertyName = "BookId";
            DataGridViewComboBoxColumn column = (DataGridViewComboBoxColumn)dgBorrowDetail.Columns[2];
            column.DisplayMember = "BookCode";
            column.ValueMember = "BookId";
            if (num == 1)
            {
                column.DataSource = Books.GetAllNotReturn();
            }
            else
            {
                column.DataSource = Books.GetAll(0);
            }

            dgBorrowDetail.Columns[3].Visible = true;
            dgBorrowDetail.Columns[3].HeaderText = "Note";
            dgBorrowDetail.Columns[3].Width = 300;
            dgBorrowDetail.Columns[3].DefaultCellStyle.Font = new Font("Poppins", 11);
            dgBorrowDetail.Columns[3].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgBorrowDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgBorrowDetail.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgBorrowDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgBorrowDetail.Columns[3].DataPropertyName = "Note";

            dgBorrowDetail.Columns[4].Visible = true;
            dgBorrowDetail.Columns[4].HeaderText = "IsReturn";
            dgBorrowDetail.Columns[4].Width = 150;
            dgBorrowDetail.Columns[4].DefaultCellStyle.Font = new Font("Poppins", 11);
            dgBorrowDetail.Columns[4].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgBorrowDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgBorrowDetail.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            DataGridViewCheckBoxColumn cell = (DataGridViewCheckBoxColumn)dgBorrowDetail.Columns[4];
            dgBorrowDetail.Columns[4].DataPropertyName = "IsReturn";
            dgBorrowDetail.Columns[4].ReadOnly = false;


            dgBorrowDetail.Columns[5].Visible = true;
            dgBorrowDetail.Columns[5].DefaultCellStyle.Font = new Font("Poppins", 11);
            dgBorrowDetail.Columns[5].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgBorrowDetail.Columns[5].HeaderText = "ReturnDate";
            dgBorrowDetail.Columns[5].Width = 150;
            dgBorrowDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgBorrowDetail.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgBorrowDetail.Columns[5].ReadOnly = false;

            //dgSaleDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgBorrowDetail.Columns[5].DataPropertyName = "ReturnDate";

        }

        void LoadCustomer()
        {
            DataTable dtCustomer = Customers.GetAll();
            cboCustomerName.DataSource = dtCustomer;
            cboCustomerName.DisplayMember = "CustomerName";
            cboCustomerName.ValueMember = "CustomerId";
        }

        bool DoValidation()
        {
            bool result = true;
            if (cboCustomerName.SelectedIndex < 0)
            {
                epCustomerName.SetError(cboCustomerName, "Please enter customer name");
                result = false;


            }
            return result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsBorrow.Count <= 0)
            {
                return;
            }

            DataRowView datarow = (DataRowView)bsBorrow.Current;
            if (datarow.IsNew)
            {
                return;
            }

            DialogResult confirmation = MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }
            Borrows.Delete(Convert.ToInt32(txtBorrowId.Text));

            MessageBox.Show("Sale has deleted successfully");

            InitializeData();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bsBorrow.AddNew();
            dtBorrowDetail.Rows.Clear();
            dgBorrowDetail.Columns[0].ReadOnly = true;
            dgBorrowDetail.Columns[1].ReadOnly = true;
            dgBorrowDetail.Columns[2].ReadOnly = false;
            dgBorrowDetail.Columns[3].ReadOnly = false;
            dgBorrowDetail.Columns[4].ReadOnly = true;
            dgBorrowDetail.Columns[5].ReadOnly = true;
            num = 1;

            SetProperty();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bsBorrow.CancelEdit();
            bsBorrow.MovePrevious();
            LoadBorrowDetail();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bsBorrow.CancelEdit();
            bsBorrow.MoveNext();
            LoadBorrowDetail();

        }

        private void dgBorrowDetail_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgBorrowDetail.DefaultCellStyle.BackColor))
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

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            dgBorrowDetail.EndEdit();
            if (!DoValidation())
            {
                return;
            }

            DataRowView datarow = (DataRowView)bsBorrow.Current;
            if (datarow.IsNew)
            {
                if (DoValidation())
                {
                    Borrow borrow = new Borrow();
                    borrow.BorrowDate = dtpBorrowDate.Value;
                    borrow.DueDate = dtpBorrowDate.Value;
                    borrow.BorrowCode = txtBorrowCode.Text.Trim();
                    borrow.CustomerId = Convert.ToInt32(cboCustomerName.SelectedValue);
                    borrow.LibrarianId = Convert.ToInt32(cboLibrarianName.SelectedValue);
                    borrow.DepositAmount = Convert.ToInt32(txtDepositAmount.Text.Trim());
                    borrow.FineAmount = Convert.ToInt32(txtFineAmount.Text.Trim());
                    borrow.MeMo = txtMemo.Text.Trim();
                    int borrowid = Borrows.Add(borrow);
                    if (borrowid > 0)
                    {
                        dtBorrowDetail.Columns["BorrowId"].DefaultValue = borrowid;
                        dgBorrowDetail.Refresh();
                        dtBorrowDetail.AcceptChanges();

                        foreach (DataRow row in dtBorrowDetail.Rows)
                        {
                            BorrowDetail borrowdetail = new BorrowDetail();
                            borrowdetail.BorrowId = borrowid;
                            if (!Convert.IsDBNull(row["BookId"]))
                            {
                                borrowdetail.BookId = Convert.ToInt32(row["BookId"].ToString());
                            }
                            else
                            {
                                MessageBox.Show("Pls select a book.");
                                return;
                            }
                            borrowdetail.Note = row["Note"].ToString();


                            if (row["IsReturn"] != DBNull.Value)
                            {
                                borrowdetail.IsReturn = Convert.ToInt32(row["IsReturn"]);
                            }
                            else
                            {
                                borrowdetail.IsReturn = 0;
                            }


                            if (!Convert.IsDBNull(row["ReturnDate"]) )
                            {
                                borrowdetail.ReturnDate = Convert.ToDateTime(row["ReturnDate"]);
                            }
                            
                            
                           
                            BorrowDetails.Add(borrowdetail);

                            //DataGridViewCheckBoxCell checkBox = row["IsReturn"] as DataGridViewCheckBoxCell;

                            //if (borrowdetail.IsReturn)
                            //{
                            //    checkBox.Value = checkBox.TrueValue;
                            //}
                            //dgBorrowDetail.Rows[4].Cells["IsReturn"].Value = borrowdetail.IsReturn;
                            //DataGridViewCheckBoxCell checkBoxCell = dgBorrowDetail.Rows[4].Cells["IsReturn"] as DataGridViewCheckBoxCell;

                            // Set the checkbox state
                            //checkBoxCell.Value = borrowdetail.IsReturn;
                        }
                    }
                    MessageBox.Show("Borrow has added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBorrow();
                }
            }
            else
            {
                if (DoValidation())
                {
                    Borrow borrow = new Borrow();
                    borrow.BorrowId = Convert.ToInt32(txtBorrowId.Text);
                    borrow.BorrowDate = dtpBorrowDate.Value;
                    borrow.IsHidden = 0;
                    borrow.BorrowCode = txtBorrowCode.Text.Trim();
                    borrow.CustomerId = Convert.ToInt32(cboCustomerName.SelectedValue);
                    borrow.LibrarianId = Convert.ToInt32(cboLibrarianName.SelectedValue);
                    borrow.DepositAmount = Convert.ToInt32(txtDepositAmount.Text.Trim());
                    borrow.FineAmount = Convert.ToInt32(txtFineAmount.Text.Trim());
                    borrow.MeMo = txtMemo.Text.Trim();
                    Borrows.Update(borrow);

                    BorrowDetails.Delete(borrow.BorrowId);
                    dgBorrowDetail.Refresh();
                    dtBorrowDetail.AcceptChanges();

                    foreach (DataRow row in dtBorrowDetail.Rows)
                    {
                        BorrowDetail borrowdetail = new BorrowDetail();
                        borrowdetail.BorrowId = borrow.BorrowId;
                        if (!Convert.IsDBNull(row["BookId"]))
                        {
                            borrowdetail.BookId = Convert.ToInt32(row["BookId"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Pls select a book.");
                            return;
                        }

                        borrowdetail.Note = row["Note"].ToString();
                        if (!Convert.IsDBNull(row["IsReturn"])){
                            borrowdetail.IsReturn = Convert.ToInt32(row["IsReturn"]);
                        }
                        else
                        {
                            borrowdetail.IsReturn = 0;
                        }


                        if (!Convert.IsDBNull(row["ReturnDate"]) )
                        {
                            borrowdetail.ReturnDate = Convert.ToDateTime(row["ReturnDate"]);
                        }
                        else
                        {
                            borrowdetail.ReturnDate = null;
                        }

                        BorrowDetails.Add(borrowdetail);

                        // Get the cell containing the checkbox
                        DataGridViewCheckBoxCell checkBoxCell = row["IsReturn"] as DataGridViewCheckBoxCell;
                    }

                    MessageBox.Show("Borow has updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBorrow();

                }
            }
        }

        private void FormBorrow_Load(object sender, EventArgs e)
        {
            DataTable dtUserPermission = AppUserPermissions.Get(user.AppUserId);

            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "BorrowCreate")
                {
                    btnNew.Visible = true;
                }
                /*if (row["AppUserPermission"].ToString() == "CustomerModify")
                {
                    btnDelete.Visible = true;
                }
                */
               
                if (row["UserPermission"].ToString() == "BorrowDelete")
                {
                    btnDelete.Visible = true;
                }

            }
            txtBorrowId.Enabled = false;
        }

        void LoadLibrarian()
        {
            DataTable dtlinrarian = Librarians.GetAll();
            cboLibrarianName.DataSource = dtlinrarian;
            cboLibrarianName.DisplayMember = "LibrarianName";
            cboLibrarianName.ValueMember = "LibrarianId";
        }

    }
}
