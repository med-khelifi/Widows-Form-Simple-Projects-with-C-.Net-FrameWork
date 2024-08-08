using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            ResetForm();
        }

        private void ResetForm()
        {
            txtPassword.PasswordChar = '\u25CF';
            isPasswordHidden = true;
            txtPassword.IconRight = Properties.Resources.hidden;

            txtPassword.PlaceholderText = "Enter Your Password";
            txtUserName.PlaceholderText = "Enter Your User Name";

            txtPassword.Text = "";
            txtUserName.Text = "";

            pbarLoadingLoginProgress.Visible = false;
            btnLogin.Visible = true;
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
                txtPassword.PasswordChar = '\u25CF';
                isPasswordHidden = true;
                txtPassword.IconRight = Properties.Resources.hidden;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Fill All Boxes To Loging", "Empty Box", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            pbarLoadingLoginProgress.Visible = true;
            btnLogin.Visible = false;
            pbarLoadingLoginProgress.Start();
            
            await Task.Delay(2500);
            pbarLoadingLoginProgress.Stop();

            clsUsers CurrentUser;

            if((CurrentUser = clsUsers.FindUser(txtUserName.Text,txtPassword.Text)) != null)
            {
                CurrentUser.SaveToLoggingHistory();
                Global.CurrentUser = CurrentUser;
                frmMainScreen frm = new frmMainScreen();
                frm.ShowDialog();
                ResetForm();
               
            }
            else
            {
                MessageBox.Show("Wong UserName or Password Please Check Your Login Info And Try Again", "Login Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);

                pbarLoadingLoginProgress.Visible = false;
                btnLogin.Visible = true;
            }
            
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
