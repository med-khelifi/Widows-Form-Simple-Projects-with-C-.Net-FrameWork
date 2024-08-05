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
    public partial class frmAddNewClientScreen : Form
    {
        public frmAddNewClientScreen()
        {
            InitializeComponent();
            InitializeControls();
        }

        bool isUserExist, isValidPinCode, isValidFirstName, //need to be fixed
            isValidLastName, isValidEmail, isValidPhone, isValidBalance;

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtPinCode_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtPinCode,ref isValidPinCode);
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtBalance,ref isValidBalance);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtPhoneNumber,ref isValidPhone);
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtFirstName,ref isValidFirstName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtLastName,ref isValidLastName);   
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtEmail, ref isValidEmail);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            clsBankClient NewClient = new clsBankClient(txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhoneNumber.Text,
                txtAccNumber.Text,
                txtPinCode.Text,
                Convert.ToDouble(txtBalance.Text));

            if (NewClient.AddClient())
            {
                MessageBox.Show("Client Add Successfully");
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void txtAccNumber_TextChanged(object sender, EventArgs e)
        {
            if (clsBankClient.isClientExist(txtAccNumber.Text) || txtAccNumber.Text == "")
            {
                txtAccNumber.BorderColor = Color.Red;
                isUserExist = true;
            }
            else
            {
                txtAccNumber.BorderColor = Color.White;
                isUserExist = false;
            }
            btnAddClient.Enabled = CheckBoxes();
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
            btnAddClient.Enabled = CheckBoxes();
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
            btnAddClient.Enabled = CheckBoxes();
        }
        private bool CheckBoxes()
        {
            return isValidPinCode
                && isValidEmail
                && isValidPhone
                && !isUserExist
                && isValidFirstName
                && isValidLastName
                && isValidBalance;
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
        }
    }
}
