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
    public partial class frmWithDrawScreen : Form
    {
        public frmWithDrawScreen()
        {
            InitializeComponent();
            InitializeControls();
        }
        
        bool isClientExist = false, isValidAmount = false;
        double Amount = 0;

        private void InitializeControls()
        {
            txtAccNumber.PlaceholderText = "Account Number";
            //txtPinCode.PlaceholderText = "PinCode";
            txtFirstName.PlaceholderText = "First Name";
            txtLastName.PlaceholderText = "Last Name";
            //txtEmail.PlaceholderText = "Email";
            //txtPhoneNumber.PlaceholderText = "Phone Number";
            txtBalance.PlaceholderText = "Balance";
            txtSearchClient.PlaceholderText = "Search Client Account Number";
            txtDeposiAmount.PlaceholderText = "Withdraw Amount";
        }

        clsBankClient Client = new clsBankClient();
        private void ClearTxtBoxes()
        {
            txtAccNumber.Text = "";
            //txtPinCode.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            //txtEmail.Text = "";
            //txtPhoneNumber.Text = "";
            txtBalance.Text = "";
            txtDeposiAmount.Text = "";
        }

        private void FillTextBoxes(clsBankClient U)
        {
            txtAccNumber.Text = U._AccountNumber;
            //txtPinCode.Text = U._PinCode;
            txtFirstName.Text = U._FirstName;
            txtLastName.Text = U._LastName;
            //txtEmail.Text = U._Email;
            //txtPhoneNumber.Text = U._Phone;
            txtBalance.Text = U._Balance.ToString();
        }

        private void txtDeposiAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtDeposiAmount.Text != "" && Double.TryParse(txtDeposiAmount.Text, out Amount))
            {
                
                txtDeposiAmount.BorderColor = Color.White;
                isValidAmount = true;
            }
            else
            {
                
                txtDeposiAmount.BorderColor = Color.Red;
                isValidAmount = false;
            }

            btnWithdraw.Enabled = isValidAmount && isClientExist;

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(Client._Balance < Amount)
            {
                errorProvider1.SetError(txtDeposiAmount, "Amount Exeed Your Balance");
                return;
            }

            if (Client.WithDraw(Amount))
            {
                MessageBox.Show("Withdraw Successfully");
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

                isClientExist = true;

                FillTextBoxes(Client);
            }
            else
            {
                ClearTxtBoxes();
                isClientExist = false;
                txtAccNumber.Text = "Client Not Found...";

            }
            btnWithdraw.Enabled = isClientExist && isValidAmount;
        }

        



    }
}
