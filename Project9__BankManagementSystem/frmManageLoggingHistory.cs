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
    public partial class frmManageLoggingHistory : Form
    {
        public frmManageLoggingHistory()
        {
            InitializeComponent();
            btnCurrentDate.Text = DateTime.Now.ToShortTimeString() + "-" + DateTime.Now.ToShortDateString();
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void frmManageLoggingHistory_Load(object sender, EventArgs e)
        {
            if (Global.CurrentUser.CheckPermissions(clsUsers.enPermession.eLogingHistory))
            {
                ShowFormInPanel(new frmShowLoggingHistory());
            }
            else
            {
                ShowFormInPanel(new frmAccessDenied());
            }
        }
    }
}
