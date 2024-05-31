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
    public partial class FormCustomerTypeAddEdit : Form
    {
        CustomerType customertype;
        bool isnew;
        public FormCustomerTypeAddEdit(CustomerType customertype)
        {
            InitializeComponent();
            
            if (customertype == null)
            {
                this.customertype = new CustomerType();
                lblTitle.Text = "New CustomerType";

                isnew = true;
                txtCustomerType.Focus();

            }
            else
            {
                lblTitle.Text = "Edit CustomerType";
                isnew = false;
                this.customertype = customertype;
                InitializeData();
                txtCustomerType.Focus();
            }
        }
        void InitializeData()
        {

            txtCustomerType.Text = customertype.CustomerTypename;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        int customertypeid = 0;
        private void FormCustomerTypeAddEdit_Load(object sender, EventArgs e)
        {
            customertypeid = customertype.CustomerTypeId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Dovalidation())
            {
                if (isnew)
                {
                    customertype = new CustomerType();

                    customertype.CustomerTypename = txtCustomerType.Text;
                   

                    CustomerTypes.Add(customertype);

                }
                else
                {
                   
                    customertype = new CustomerType();
                    customertype.CustomerTypeId = customertypeid;
                    customertype.CustomerTypename = txtCustomerType.Text;


                    CustomerTypes.Update(customertype);
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private bool Dovalidation()
        {
            bool result = true;
            if (txtCustomerType.Text.Trim() == "")
            {
                epCustomerTypeName.SetError(txtCustomerType, "Please Enter CustomerType Name");
                result = false;
            }
            return result;
        }
    }
}
