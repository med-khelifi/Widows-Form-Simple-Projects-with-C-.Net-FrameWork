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
    public partial class frmManageCurrencyScreen : Form
    {
        public frmManageCurrencyScreen()
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

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eShowCurrencyList))
                ShowFormInPanel(new frmShowCurrenciesList());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void frmManageCurrencyScreen_Load(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eShowCurrencyList))
                ShowFormInPanel(new frmShowCurrenciesList());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eUpdateCurrecyRate))
                ShowFormInPanel(new frmUpdateCurrencyRateScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eExchangeCurrency))
                ShowFormInPanel(new frmExchangeScreen());
            else
                ShowFormInPanel(new frmAccessDenied());
        }
    }
}
