using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project9__BankManagementSystem
{
    public partial class frmShowUsersList : Form
    {
        public frmShowUsersList()
        {
            InitializeComponent();
        }

        private void frmShowUsersList_Load(object sender, EventArgs e)
        {
            List<clsUsers> UsersData = clsUsers.GetUsersList();
            if (UsersData != null && UsersData.Count > 0)
            {
                DataGridUsersList.DataSource = UsersData;
                DataGridUsersList.Refresh();
            }
            else
            {
                MessageBox.Show("No users data available to display.");
            }
        }
    }
}
