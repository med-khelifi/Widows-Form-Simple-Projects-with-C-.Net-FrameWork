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
    public partial class frmDeleteUser : Form
    {
        public frmDeleteUser()
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

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            
            if ((User = clsUsers.FindUser(txtSearchUser.Text)) != null)
            {
                txtAccNumber.BorderColor = Color.White;
                txtAccNumber.Text = txtSearchUser.Text;
                
                btnDeleteUser.Enabled = true;

                FillTextBoxes(User);
            }
            else
            {
                ClearTxtBoxes();
                btnDeleteUser.Enabled = false;
                txtAccNumber.Text = "User Not Found...";
                
            }
        }
        clsUsers User;
        private void ClearTxtBoxes()
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (User.DeleteUser())
            {
                MessageBox.Show("User Deleted Successfully");
                ClearTxtBoxes();
            }
            else
            {
                MessageBox.Show("Error");

            }
        }
    }
}
