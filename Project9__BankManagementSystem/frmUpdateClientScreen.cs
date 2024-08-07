using Guna.UI2.WinForms;
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
    public partial class frmUpdateClientScreen : Form
    {
        bool isValidPinCode, isValidEmail, isValidPhone,
            isUserExist, isValidFirstName, isValidLastName , isValidBalance;


        public frmUpdateClientScreen()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void Clear()
        {
            txtAccNumber.Text = "";
            txtBalance.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtPinCode.Text = "";
            //txtSearchUser.Text = "";
        }
        private void ValidateTextBoxNumbers(Guna2TextBox textBox, ref bool isValidFlag)
        {
            if (string.IsNullOrEmpty(textBox.Text) || !textBox.Text.All(char.IsDigit))
            {
                textBox.BorderColor = Color.Red;
                isValidFlag = false;
            }
            else
            {
                textBox.BorderColor = Color.White;
                isValidFlag = true;
            }
            btnUpdateClient.Enabled = CheckBoxes();
        }

        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtPinCode, ref isValidPinCode);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtFirstName, ref isValidFirstName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtLastName, ref isValidLastName);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtEmail, ref isValidEmail);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtPhoneNumber, ref isValidPhone);
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtBalance, ref isValidBalance);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
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

        private void ValidateTextBox(Guna2TextBox textBox, ref bool isValidFlag)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BorderColor = Color.Red;
                isValidFlag = false;
            }
            else
            {
                textBox.BorderColor = Color.White;
                isValidFlag = true;
            }
            btnUpdateClient.Enabled = CheckBoxes();
        }

        private bool CheckBoxes()
        {
            return isValidPinCode
                && isValidEmail
                && isValidPhone
                && isUserExist
                && isValidFirstName
                && isValidLastName
                && isValidBalance;
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            clsBankClient Client;
            if ((Client = clsBankClient.FindClient(txtSearchClient.Text)) != null)
            {
                txtAccNumber.BorderColor = Color.White;
                txtAccNumber.Text = txtSearchClient.Text;
                isUserExist = true;

                FillTextBoxes(Client);
            }
            else
            {
                txtAccNumber.BorderColor = Color.Red;
                txtAccNumber.Text = "User Not Found...";
                Clear();
                isUserExist = false;
            }
            btnUpdateClient.Enabled = CheckBoxes();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            clsBankClient Client = new clsBankClient(txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhoneNumber.Text,
                txtAccNumber.Text,
                txtPinCode.Text,
                Convert.ToDouble(txtBalance.Text));

            if (Client.UpdateClient())
            {
                MessageBox.Show("Client Updated Successfully");
                Clear();
            }
            else
            {
                MessageBox.Show("Error");

            }
        }
    }
}
