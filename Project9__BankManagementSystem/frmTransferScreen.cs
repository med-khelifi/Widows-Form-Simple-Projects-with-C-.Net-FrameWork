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
    public partial class frmTransferScreen : Form
    {
        public frmTransferScreen()
        {
            InitializeComponent();
            InitializeControls();
        }

        bool isClientSenderExist = false, isValidAmount = false, isClientReceiverExist = false;
        double Amount = 0;

        private void InitializeControls()
        {
            txtAccNumberSender.PlaceholderText = "Account Number";
            txtAccNumberReceiver.PlaceholderText = "Account Number";
            //txtPinCode.PlaceholderText = "PinCode";
            txtFirstNameSender.PlaceholderText = "First Name";
            txtFirstNameReceiver.PlaceholderText = "First Name";
            txtLastNameSender.PlaceholderText = "Last Name";
            txtLastNameReceiver.PlaceholderText = "Last Name";
            //txtEmail.PlaceholderText = "Email";
            //txtPhoneNumber.PlaceholderText = "Phone Number";
            txtBalanceSender.PlaceholderText = "Balance";
            txtBalanceReceiver.PlaceholderText = "Balance";

            txtSearchSender.PlaceholderText = "Search Sender Account Number";
            txtSearchReceiver.PlaceholderText = "Search Receiver Account Number";
            txtTransferAmount.PlaceholderText = "Transfer Amount";
        }

        clsBankClient Sender = new clsBankClient();
        clsBankClient Receiver = new clsBankClient();
        private void ClearTxtBoxesSender()
        {
            txtAccNumberSender.Text = "";
            txtFirstNameSender.Text = "";
            txtLastNameSender.Text = "";

            
            txtBalanceSender.Text = "";
           
            txtTransferAmount.Text = "";
               
        }

        private void ClearTxtBoxesReceiver()
        {
            
            txtAccNumberReceiver.Text = "";
            txtFirstNameReceiver.Text = "";
            txtLastNameReceiver.Text = "";
          

            txtBalanceReceiver.Text = "";
            txtTransferAmount.Text = "";
        }

        private void FillSenderTextBoxes(clsBankClient U)
        {
            txtAccNumberSender.Text = U._AccountNumber;
            //txtPinCode.Text = U._PinCode;
            txtFirstNameSender.Text = U._FirstName;
            txtLastNameSender.Text = U._LastName;
            //txtEmail.Text = U._Email;
            //txtPhoneNumber.Text = U._Phone;
            txtBalanceSender.Text = U._Balance.ToString();
        }

        private void FillReceiverTextBoxes(clsBankClient U)
        {
            txtAccNumberReceiver.Text = U._AccountNumber;
            //txtPinCode.Text = U._PinCode;
            txtFirstNameReceiver.Text = U._FirstName;
            txtLastNameReceiver.Text = U._LastName;
            //txtEmail.Text = U._Email;
            //txtPhoneNumber.Text = U._Phone;
            txtBalanceReceiver.Text = U._Balance.ToString();
        }

        private void txtSearchSender_TextChanged(object sender, EventArgs e)
        {
            if ((Sender = clsBankClient.FindClient(txtSearchSender.Text)) != null)
            {
                txtAccNumberSender.BorderColor = Color.White;
                txtAccNumberSender.Text = txtSearchSender.Text;

                isClientSenderExist = true;

                FillSenderTextBoxes(Sender);
            }
            else
            {
                ClearTxtBoxesSender();
                isClientSenderExist = false;
                txtAccNumberSender.Text = "Client Not Found...";

            }
            btnTransfer.Enabled = isClientSenderExist && isValidAmount && isClientReceiverExist;
        }

        private void txtSearchReceiver_TextChanged(object sender, EventArgs e)
        {
            if ((Receiver = clsBankClient.FindClient(txtSearchReceiver.Text)) != null)
            {
                txtAccNumberReceiver.BorderColor = Color.White;
                txtAccNumberReceiver.Text = txtSearchReceiver.Text;

                isClientReceiverExist = true;
                //
                FillReceiverTextBoxes(Receiver);
            }
            else
            {
                ClearTxtBoxesReceiver();
                isClientReceiverExist = false;
                txtAccNumberReceiver.Text = "Client Not Found...";

            }
            btnTransfer.Enabled = isClientSenderExist && isValidAmount && isClientReceiverExist;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (Sender._Balance < Amount)
            {
                errorProvider1.SetError(txtTransferAmount, "Amount Exeed Your Balance");
                return;
            }
            if (Sender._AccountNumber == Receiver._AccountNumber)
            {
                errorProvider1.SetError(txtAccNumberSender, "Cannot Transfer to the same Account");
                errorProvider1.SetError(txtAccNumberReceiver, "Cannot Transfer to the same Account");
                return;
            }

            if (Sender.Transfer(ref Receiver, Amount))
            {
                MessageBox.Show("Transfer Successfully");
                ClearTxtBoxesReceiver();
                ClearTxtBoxesSender ();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void txtTransferAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtTransferAmount.Text != "" && Double.TryParse(txtTransferAmount.Text, out Amount))
            {

                txtTransferAmount.BorderColor = Color.White;
                isValidAmount = true;
            }
            else
            {

                txtTransferAmount.BorderColor = Color.Red;
                isValidAmount = false;
            }

            btnTransfer.Enabled = isValidAmount && isClientReceiverExist && isClientSenderExist;
        }

        

       
    }
}
