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
    public partial class frmAddNewUserScreen : Form
    {
        

        int Permissions = 0;
        public frmAddNewUserScreen()
        {
            InitializeComponent();
            InitializeControls();
        }
        bool isUserExist, isValidPassword, isValidFirstName, //need to be fixed
            isValidLastName, isValidEmail, isValidPhone, isValidPermissions;
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
            btnAddUser.Enabled = CheckBoxes();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtPassword, ref isValidPassword);
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

        private void btnSetPermissions_Click(object sender, EventArgs e)
        {
            using(frmPermissions frm = new frmPermissions())
            {
                frm.ShowDialog();
                if(frm.DialogResult == DialogResult.OK)
                {
                    Permissions = frm.GetPermissions();
                    txtPermissions.Text = Permissions.ToString();
                    frm.Close();
                }
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            clsUsers NewUser = new clsUsers(txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhoneNumber.Text,
                txtAccNumber.Text,
                txtPassword.Text,
                (int)Permissions);

            if (NewUser.AddUser())
            {
                MessageBox.Show("User Add Successfully");
               btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");
               
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtPhoneNumber, ref isValidPhone);
        }

        private void txtPermissions_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtPermissions, ref isValidPermissions);
        }

        private void txtAccNumber_TextChanged(object sender, EventArgs e)
        {
            if (clsUsers.isUserExist(txtAccNumber.Text) || txtAccNumber.Text == "")
            {            
                txtAccNumber.BorderColor = Color.Red;
                isUserExist = true;
            }
            else
            {
                txtAccNumber.BorderColor = Color.White;
                isUserExist = false;
            }
            btnAddUser.Enabled = CheckBoxes();
        }

        private bool CheckBoxes()
        {
            return isValidPassword
                && isValidEmail
                && isValidPhone
                && !isUserExist
                && isValidFirstName
                && isValidLastName
                && isValidPermissions;
        }

        private void InitializeControls()
        {
            txtAccNumber.PlaceholderText = "Account Number";
            txtPassword.PlaceholderText = "Password";
            txtFirstName.PlaceholderText = "First Name";
            txtLastName.PlaceholderText = "Last Name";
            txtEmail.PlaceholderText = "Email";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPermissions.PlaceholderText = "No Permissions Set";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccNumber.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtPermissions.Text = "";
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
            btnAddUser.Enabled = CheckBoxes();
        }
    }

}
