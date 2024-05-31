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
    public partial class FormCustomerAddEdit : Form
    {
        Customer customer;
        bool isnew;
        public FormCustomerAddEdit(Customer customer)
        {
            InitializeComponent();
            if (customer == null)
            {
                this.customer = new Customer();
                lblTitle.Text = "New Customer";

                isnew = true;
                txtCustomerName.Focus();

            }
            else
            {
                lblTitle.Text = "Edit Customer";
                isnew = false;
                this.customer = customer;
                InitializeData();
                txtCustomerName.Focus();
            }
        }
        void InitializeData()
        {


            txtCustomerCode.Text = customer.CustomerCode;
            cboCustomerType.Text = customer.CustomerTypeId.ToString();
            txtCustomerName.Text = customer.CustomerName;
            txtSex.Text = customer.Sex;
            dtpDob.Value = customer.DoB;
           
            txtPoB.Text = customer.PoB;
            txtPhone.Text = customer.Phone;
            txtAddress.Text = customer.Address;

        }
        int customerid = 0;
        private void FormCustomerAddEdit_Load(object sender, EventArgs e)
        {
            customerid = customer.CustomerId;
            
            DataTable dtCustomerType = CustomerTypes.GetAll();
            cboCustomerType.DataSource = dtCustomerType;
            cboCustomerType.DisplayMember = "CustomerTypeName";
            cboCustomerType.ValueMember = "CustomerTypeId";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Dovalidation())
            {
                if (isnew)
                {
                    customer = new Customer();

                    customer.CustomerCode = txtCustomerCode.Text;
                    customer.CustomerTypeId = Convert.ToInt32(cboCustomerType.SelectedValue);
                    customer.CustomerName= txtCustomerName.Text;
                    customer.Sex = txtSex.Text;
                    customer.DoB = dtpDob.Value;
                    customer.PoB = txtPoB.Text;
                    customer.Phone = txtPhone.Text;
                    customer.Address = txtAddress.Text;
                    Customers.Add(customer);
                }
                
                else
                {
                    customer = new Customer();
                    customer.CustomerId = customerid;
                    customer.IsHidden = 0;
                    customer.CustomerCode = txtCustomerCode.Text;
                    customer.CustomerTypeId = Convert.ToInt32(cboCustomerType.SelectedValue);
                    customer.CustomerName = txtCustomerName.Text;
                    customer.Sex = txtSex.Text.Substring(0, 1);
                    customer.DoB = dtpDob.Value;

                    customer.PoB = txtPoB.Text;
                    customer.Phone = txtPhone.Text;
                    customer.Address = txtAddress.Text;

                    Customers.Update(customer);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool Dovalidation()
        {
            bool result = true;
            if (txtCustomerName.Text.Trim() == "")
            {
                epCustomerName.SetError(txtCustomerName, "Please Enter Customer Name");
                result = false;
            }
            return result;
        }
    }
}
