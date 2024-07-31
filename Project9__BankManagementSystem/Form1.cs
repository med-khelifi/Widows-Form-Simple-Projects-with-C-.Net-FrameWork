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
    public partial class frmLoginScreen : Form
    {
        private bool isPasswordHidden = false;
        public frmLoginScreen()
        {
            InitializeComponent();
            RestartForm();
        }

        private void RestartForm()
        {
            txtPassword.PasswordChar = '*';
            isPasswordHidden = true;
            txtPassword.IconRight = Properties.Resources.hidden;

            txtPassword.PlaceholderText = "Enter Your Password";
            txtUserName.PlaceholderText = "Enter Your User Name";
        }

        private void ShowHidePassword(object sender, EventArgs e)
        {

            if (isPasswordHidden) 
            {
                txtPassword.PasswordChar = default;
                isPasswordHidden = false;
                txtPassword.IconRight = Properties.Resources.eye;
            }
            else
            {
                txtPassword.PasswordChar = '*';
                isPasswordHidden = true;
                txtPassword.IconRight = Properties.Resources.hidden;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMainScreen frm = new frmMainScreen(); 
            frm.ShowDialog();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
