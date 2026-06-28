using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckPointBusinessLayer;

namespace Check_Point_Manager
{
    public partial class frmAddEditCustomer : Form
    {
        private enum enMode { AddNew = 0, Update = 1};
        private enMode _Mode = enMode.AddNew;
        private int _CustomerID = -1;
        private clsCustomer _Customer;
        private const string _AddNewTitle = "Add New Customer";
        private const string _UpdateTitle = "Update Customer";

        public frmAddEditCustomer()
        {
            InitializeComponent();

            _Mode = enMode.AddNew;
        }
        public frmAddEditCustomer(int CustomerID)
        {
            InitializeComponent();

            this._CustomerID = CustomerID;

            _Mode = enMode.Update;

        }
        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = _AddNewTitle;

                _Customer = new clsCustomer();
            }
            else
            {
                lblTitle.Text = _UpdateTitle;
            }

            lblCustomerID.Text = "[????]";
            lblCustomerInfoName.Text = "[????]";
            lblCustomerInfoPhone.Text = "[????]";
            lblCreatedDate.Text = DateTime.Now.ToString("d/M/yyyy");
            lblCreatedBy.Text = clsUser.Current?.UserName ?? "";
            lblInfoNotes.Text = "[????]";
        }
        private void _LoadCustomerData()
        {
            _Customer = clsCustomer.FindByID(_CustomerID);

            if(_Customer == null )
            {
                MessageBox.Show("Error loading customer info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblCustomerID.Text = _Customer.CustomerID.ToString();
            lblCustomerInfoName.Text = _Customer.CustomerName;
            lblCustomerInfoPhone.Text = _Customer.PhoneNumber;
            lblCreatedDate.Text = _Customer.CreatedDate.ToString("d/M/yyyy");
            lblCreatedBy.Text = clsUser.FindByID(_Customer.CreatedByUserID)?.UserName ??  "";
            lblInfoNotes.Text = _Customer.Notes == "" ? "No notes" : _Customer.Notes;

            txbCustomerName.Text = _Customer.CustomerName;
            txbPhoneNumber.Text = _Customer.PhoneNumber;
            txbNotes.Text = _Customer.Notes;
        }

        private void frmAddEditCustomer_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
                _LoadCustomerData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbCustomerName.Text))
            {
                MessageBox.Show("Customer name required", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbCustomerName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txbPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number required", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPhoneNumber.Focus();
                return;
            }

            if (txbPhoneNumber.Text.Length < 8)
            {
                MessageBox.Show("Invalid Phone Number", "Wrong Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPhoneNumber.Focus();
                return;
            }

            _Customer.CustomerName = txbCustomerName.Text.Trim();
            _Customer.PhoneNumber = txbPhoneNumber.Text.Trim();
            _Customer.Notes = txbNotes.Text.Trim();

            if (!_Customer.Save())
            {
                MessageBox.Show("Error While Saving Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Customer data saved successfully", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblTitle.Text = _UpdateTitle;
            _CustomerID = _Customer.CustomerID;

            _Mode = enMode.Update;

            _LoadCustomerData();
        }

        private void txbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }
    }
}
