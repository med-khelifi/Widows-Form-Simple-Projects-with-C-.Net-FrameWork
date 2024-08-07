using Project9__BankManagementSystem;
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
    public partial class frmManageClientsScreen : Form
    {
        public frmManageClientsScreen()
        {
            InitializeComponent();
        }

        private void ShowFormInPanel(Form form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(form);
            this.mainPanel.Tag = form;
            form.Show();

        }


        private void btnClientList_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eShowClientsList))
                ShowFormInPanel(new frmShowClientList());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void frmManageClientsScreen_Load(object sender, EventArgs e)
        {
            if(Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eShowClientsList))
                 ShowFormInPanel(new frmShowClientList());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eAddNewClients))
                ShowFormInPanel(new frmAddNewClientScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eUpdateClient))
                ShowFormInPanel(new frmUpdateClientScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {

            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eDeleteClient))
                ShowFormInPanel(new frmDeleteClientScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
