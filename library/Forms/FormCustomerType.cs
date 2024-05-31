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
    public partial class FormCustomerType : Form
    {
        DataTable dtcustomertype;
        AppUser user;
        public FormCustomerType(AppUser user)
        {
            InitializeComponent();
            InitializeData();
            this.user = user;

        }
        public void InitializeData()
        {
            dtcustomertype = new DataTable();
            dtcustomertype = CustomerTypes.GetAll();
            dgCustomerType.DataSource = dtcustomertype;
            dgCustomerType.Columns[0].Visible = false;

            dgCustomerType.Columns[1].HeaderText = "CustomerType Name";
            dgCustomerType.Columns[1].Width = 200;
            dgCustomerType.Columns[1].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgCustomerType.Columns[1].DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);
            dgCustomerType.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomerType.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomerType.Columns[1].Visible = true;
            dgCustomerType.DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerTypeAddEdit customerTypeAddEdit = new FormCustomerTypeAddEdit(null);

            if (customerTypeAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void FormCustomerType_Load(object sender, EventArgs e)
        {
            DataTable dtUserPermission = AppUserPermissions.Get(user.AppUserId);

            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "CustomerTypeCreate")
                {
                    btnNew.Visible = true;
                }
                if (row["UserPermission"].ToString() == "CustomerTypeModify")
                {
                    btnEdit.Visible = true;
                }
                if (row["UserPermission"].ToString() == "CustomerTypeDelete")
                {
                    btnDelete.Visible = true;
                }
                


            }
            InitializeData();
        }

        private void dgCustomerType_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgCustomerType.DefaultCellStyle.BackColor))
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgCustomerType.SelectedRows.Count > 0)
            {
                customertypeid = Convert.ToInt32(dgCustomerType.SelectedRows[0].Cells[0].Value.ToString());
                CustomerType customertype = CustomerTypes.Get(customertypeid);

                FormCustomerTypeAddEdit formCustomerTypeAddEdit = new FormCustomerTypeAddEdit(customertype);

                if (formCustomerTypeAddEdit.ShowDialog() == DialogResult.OK)
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
                int customertypeid = Convert.ToInt32(dgCustomerType.SelectedRows[0].Cells["CustomerTypeId"].Value.ToString());

                CustomerTypes.Delete(customertypeid);

                MessageBox.Show("Librarian had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();
            }
        }
        int customertypeid = 0;
        private void dgCustomerType_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCustomerType.SelectedRows.Count > 0)
            {
                customertypeid = Convert.ToInt32(dgCustomerType.SelectedRows[0].Cells[0].Value.ToString());
                CustomerType customertype = CustomerTypes.Get(customertypeid);

                if (customertype != null)
                {


                    txtCustomertype.Text = customertype.CustomerTypename;

                }
            }
        }
    }
}
