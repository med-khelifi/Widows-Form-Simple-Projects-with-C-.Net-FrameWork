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
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
            if(Global.CurrentUser != null)
                lblCurrentUser.Text = "User : " + Global.CurrentUser.GetFullName();
            else
                lblCurrentUser.Text = "User : No User Logged in";

            lblCurrentTime.Text = DateTime.Now.ToString("hh : mm  tt - dddd MMMM d");

            txtWelcome.Text = "Welcome Back Mr \n" + Global.CurrentUser.GetFullName() +
                "\nSelect One Of The Following Options To Continue ";
        }

        private void btnLogOutCliked(object sender, EventArgs e)
        {
            this.Close();
            Global.CurrentUser = null;
        }

        private void ManageUser_Cliked(object sender, EventArgs e)
        {
            frmManageUsersScreen frm = new frmManageUsersScreen();
            frm.ShowDialog();
        }

        private void ManageClients_Clik(object sender, EventArgs e)
        {
            frmManageClientsScreen frm = new frmManageClientsScreen();
            frm.ShowDialog();
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            frmManageLoggingHistory frm = new frmManageLoggingHistory();
            frm.ShowDialog();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            frmManageTransactionScreen frm = new frmManageTransactionScreen();
            frm.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            frmManageCurrencyScreen frm = new frmManageCurrencyScreen();
            frm.ShowDialog();
        }
    }
}
