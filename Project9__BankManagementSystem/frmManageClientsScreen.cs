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
            ShowFormInPanel(new frmShowClientList());   
        }

        private void frmManageClientsScreen_Load(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmShowClientList());
        }

        private void btnAddNewClient_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new frmAddNewClientScreen());
        }
    }
}
