using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9__BankManagementSystem
{
    public partial class frmDeleteClientScreen : Form
    {
        public frmDeleteClientScreen()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
            txtAccNumber.PlaceholderText = "Account Number";
            txtPinCode.PlaceholderText = "PinCode";
            txtFirstName.PlaceholderText = "First Name";
            txtLastName.PlaceholderText = "Last Name";
            txtEmail.PlaceholderText = "Email";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtBalance.PlaceholderText = "Balance";
            txtSearchClient.PlaceholderText = "Search Client Account Number";
        }

        clsBankClient Client;
        private void ClearTxtBoxes()
        {
            txtAccNumber.Text = "";
            txtPinCode.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtBalance.Text = "";
            //txtSearchUser.Text = "";
        }

        private void FillTextBoxes(clsBankClient U)
        {
            txtAccNumber.Text = U._AccountNumber;
            txtPinCode.Text = U._PinCode;
            txtFirstName.Text = U._FirstName;
            txtLastName.Text = U._LastName;
            txtEmail.Text = U._Email;
            txtPhoneNumber.Text = U._Phone;
            txtBalance.Text = U._Balance.ToString();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (Client.DeleteClient())
            {
                MessageBox.Show("Client Deleted Successfully");
                ClearTxtBoxes();
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            if ((Client = clsBankClient.FindClient(txtSearchClient.Text)) != null)
            {
                txtAccNumber.BorderColor = Color.White;
                txtAccNumber.Text = txtSearchClient.Text;

                btnDeleteClient.Enabled = true;

                FillTextBoxes(Client);
            }
            else
            {
                ClearTxtBoxes();
                btnDeleteClient.Enabled = false;
                txtAccNumber.Text = "Client Not Found...";

            }
        }
    }
}
