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
    public partial class frmManageUsersScreen : Form
    {
        public frmManageUsersScreen()
        {
            InitializeComponent();
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eShowUsersList))
                ShowFormInPanel(new frmShowUsersList());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

       private void ShowFormInPanel(Form form )
        {
            if(this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();

        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eShowUsersList))
                ShowFormInPanel(new frmShowUsersList());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eAddNewUser))
                ShowFormInPanel(new frmAddNewUserScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eUpdateUser))
                ShowFormInPanel(new frmUpdateUserScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eDeleteUser))
                ShowFormInPanel(new frmDeleteUser());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
