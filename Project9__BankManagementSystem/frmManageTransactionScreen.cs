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
    public partial class frmManageTransactionScreen : Form
    {
        public frmManageTransactionScreen()
        {
            InitializeComponent();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eDeposit))
                ShowFormInPanel(new frmDepositScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
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

        private void frmManageTransactionScreen_Load(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eDeposit))
                ShowFormInPanel(new frmDepositScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eWithdraw))
                ShowFormInPanel(new frmWithDrawScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eTransfer))
                ShowFormInPanel(new frmTransferScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnTransferHistory_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eTransferHistory))
                ShowFormInPanel(new frmShowTransferLogsList());
            else
                ShowFormInPanel(new frmAccessDenied());
        }
    }
}
