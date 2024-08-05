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
            ShowFormInPanel(new frmShowUsersList());
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
            ShowFormInPanel(new frmShowUsersList());
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddNewUserScreen());
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmUpdateUserScreen());
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmDeleteUser());
        }
    }
}
