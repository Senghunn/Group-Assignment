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
    public partial class FormCustomer : Form
    {
        DataTable dtcustomer;
        BindingSource bscustomer;
        AppUser user;
        public FormCustomer(AppUser user)
        {
            InitializeComponent();
            this.user = user;
        }

        public void InitializeData()
        {
            
            LoadCustomerType();
            LoadCustomer();
        }
        void LoadCustomerType()
        {
            DataTable dtCustomerType = CustomerTypes.GetAll();
            cboCustomerType.DataSource = dtCustomerType;
            cboCustomerType.DisplayMember = "CustomerTypeName";
            cboCustomerType.ValueMember = "CustomerTypeId";
        }

        void LoadCustomer()
        {
            dtcustomer = new DataTable();
            bscustomer = new BindingSource();
            dtcustomer = Customers.GetAll();
            dgCustomer.DataSource = dtcustomer;
            bscustomer.DataSource = dtcustomer;
            dgCustomer.Columns[0].DataPropertyName = "CustomerId";
            dgCustomer.Columns[0].Visible = false;

            dgCustomer.Columns[1].DataPropertyName = "IsHidden";
            dgCustomer.Columns[1].Visible = false;
            dgCustomer.Columns[2].DataPropertyName = "CustomerCode";
            dgCustomer.Columns[2].Visible = false;

            dgCustomer.Columns[3].DataPropertyName = "CustomerTypeId";
            dgCustomer.Columns[3].Visible = false;
            dgCustomer.Columns[4].HeaderText = "Customer Name";
            dgCustomer.Columns[4].DataPropertyName = "CustomerName";
            dgCustomer.Columns[4].Width = 200;
            dgCustomer.Columns[4].HeaderCell.Style.Font = new Font("Poppins", 12, FontStyle.Regular);
            dgCustomer.Columns[4].DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);
            dgCustomer.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgCustomer.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgCustomer.Columns[4].Visible = true;
            dgCustomer.DefaultCellStyle.Font = new Font("Poppins", 11, FontStyle.Regular);

            dgCustomer.Columns[5].DataPropertyName = "Sex";
            dgCustomer.Columns[5].Visible = false;
            dgCustomer.Columns[6].DataPropertyName = "DoB";
            dgCustomer.Columns[6].Visible = false;
            dgCustomer.Columns[7].DataPropertyName = "PoB";
            dgCustomer.Columns[7].Visible = false;
            dgCustomer.Columns[8].DataPropertyName = "Phone";
            dgCustomer.Columns[8].Visible = false;
            dgCustomer.Columns[9].DataPropertyName = "Address";
            dgCustomer.Columns[9].Visible = false;





            txtCustomerCode.DataBindings.Clear();
            txtCustomerCode.DataBindings.Add(new Binding("Text", bscustomer, "CustomerCode"));

            cboCustomerType.DataBindings.Clear();
            cboCustomerType.DataBindings.Add(new Binding("SelectedValue", bscustomer, "CustomerTypeId"));

            txtCustomerName.DataBindings.Clear();
            txtCustomerName.DataBindings.Add(new Binding("Text", bscustomer, "CustomerName"));

            txtSex.DataBindings.Clear();
            txtSex.DataBindings.Add(new Binding("Text", bscustomer, "Sex"));

            dtpDob.DataBindings.Clear();
            dtpDob.DataBindings.Add(new Binding("Text", bscustomer, "DoB", true));


            txtPoB.DataBindings.Clear();
            txtPoB.DataBindings.Add(new Binding("Text", bscustomer, "PoB"));
            txtPhone.DataBindings.Clear();
            txtPhone.DataBindings.Add(new Binding("Text", bscustomer, "Phone"));

            txtAddress.DataBindings.Clear();
            txtAddress.DataBindings.Add(new Binding("Text", bscustomer, "Address"));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormCustomerAddEdit CustomerAddEdit = new FormCustomerAddEdit(null);

            if (CustomerAddEdit.ShowDialog() == DialogResult.OK)
            {
                InitializeData();
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            DataTable dtUserPermission = AppUserPermissions.Get(user.AppUserId);

            foreach (DataRow row in dtUserPermission.Rows)
            {
                if (row["UserPermission"].ToString() == "CustomerCreate")
                {
                    btnNew.Visible = true;
                }
                if (row["UserPermission"].ToString() == "CustomerModify")
                {
                    btnEdit.Visible = true;
                }
                if (row["UserPermission"].ToString() == "CustomerDelete")
                {
                    btnDelete.Visible = true;
                }
               


            }
            InitializeData();
        }

        private void dgCustomer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex > -1)
            {
                e.Handled = true;
                using (Brush b = new SolidBrush(dgCustomer.DefaultCellStyle.BackColor))
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
            if (dgCustomer.SelectedRows.Count > 0)
            {
                customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells[0].Value.ToString());
                Customer customer = Customers.Get(customerid);

                FormCustomerAddEdit formCustomerAddEdit = new FormCustomerAddEdit(customer);

                if (formCustomerAddEdit.ShowDialog() == DialogResult.OK)
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
                int customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells["CustomerId"].Value.ToString());

                Customers.Delete(customerid);

                MessageBox.Show("Customer had deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InitializeData();
            }
        }
        int customerid = 0;

        private void dgCustomer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgCustomer.SelectedRows.Count > 0)
            {
                customerid = Convert.ToInt32(dgCustomer.SelectedRows[0].Cells[0].Value.ToString());
                Customer customer = Customers.Get(customerid);

                if (customer != null)
                {

                    txtCustomerCode.Text = customer.CustomerCode;
                    cboCustomerType.SelectedValue = customer.CustomerTypeId;
                    txtCustomerName.Text = customer.CustomerName;
                    txtSex.Text = customer.Sex;
                    dtpDob.Value = customer.DoB;

                    txtPoB.Text = customer.PoB;
                    txtPhone.Text = customer.Phone;
                    txtAddress.Text = customer.Address;
                }



            }
        }
    }
}
