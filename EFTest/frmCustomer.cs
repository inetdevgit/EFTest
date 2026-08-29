using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTest
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid = txtCustId.Text;
            string name = txtCustName.Text;
            string addr = txtAddr.Text;
            EFTestBR.BR.Customer.Save(cid, name, addr);
            MessageBox.Show("Customer saved successfully.");
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EFTestBR.BR.Customer.Delete(txtCustId.Text);
            ClearTextBoxes();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKey = txtCustId.Text;
            if (string.IsNullOrEmpty(searchKey))
            {
                MessageBox.Show("Please enter a Customer ID to search.");
                return;
            }
            EFTestDAL.Entity.Customer rec = EFTestBR.BR.Customer.SearchById(searchKey);
            if (rec == null)
            {
                MessageBox.Show("Customer not found.");
                ClearTextBoxes();
            }
            else
            {
                txtCustName.Text = rec.CustName;
                txtAddr.Text = rec.Address;
                txtCustId.Enabled = false;
            }
        }
        private void ClearTextBoxes()
        {
            txtCustId.Clear();
            txtCustName.Clear();
            txtAddr.Clear();
            txtCustId.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
