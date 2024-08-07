using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Project9__BankManagementSystem
{
    public partial class frmUpdateUserScreen : Form
    {
        bool isUserExist, isValidPassword, isValidFirstName, //need to be fixed
            isValidLastName, isValidEmail, isValidPhone, isValidPermissions;

        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAccNumber.Text = "";
            txtPassword.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtPermissions.Text = "";
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
            btnUpdateUser.Enabled = CheckBoxes();
        }


        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            clsUsers User;
            if ((User = clsUsers.FindUser(txtSearchUser.Text)) != null)
            {
                txtAccNumber.BorderColor = Color.White;
                txtAccNumber.Text = txtSearchUser.Text;
                isUserExist = true;
                
                FillTextBoxes(User);
            }
            else
            {
                txtAccNumber.BorderColor = Color.Red;
                txtAccNumber.Text = "User Not Found...";
                btnClear_Click(sender,e);
                isUserExist = false;
            }
            btnUpdateUser.Enabled = CheckBoxes();
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

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxNumbers(txtPhoneNumber, ref isValidPhone);
        }

        private void txtPermissions_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox(txtPermissions, ref isValidPermissions);
        }

        private void btnSetPermissions_Click(object sender, EventArgs e)
        {
            using (frmPermissions frm = new frmPermissions())
            {
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    Permissions = frm.GetPermissions();
                    txtPermissions.Text = Permissions.ToString();
                    frm.Close();
                }
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            clsUsers User =new clsUsers(txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhoneNumber.Text,
                txtAccNumber.Text,
                txtPassword.Text,
                Convert.ToInt32(txtPermissions.Text));

            if (User.UpdateUser())
            {
                MessageBox.Show("User Updated Successfully");
                btnClear_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void FillTextBoxes(clsUsers U)
        {
            txtAccNumber.Text = U._AccountNumber;
            txtPassword.Text = U._Password;
            txtFirstName.Text = U._FirstName;
            txtLastName.Text = U._LastName;
            txtEmail.Text = U._Email;
            txtPhoneNumber.Text = U._Phone;
            txtPermissions.Text = U._Permessions.ToString();
        }

        int Permissions = 0;
        public frmUpdateUserScreen()
        {
            InitializeComponent();
            InitializeControls();
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
            txtSearchUser.PlaceholderText = "Search User Account Number";
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
            btnUpdateUser.Enabled = CheckBoxes();
        }

        private bool CheckBoxes()
        {
            return isValidPassword
                && isValidEmail
                && isValidPhone
                && isUserExist
                && isValidFirstName
                && isValidLastName
                && isValidPermissions;
        }
        
    }
}
