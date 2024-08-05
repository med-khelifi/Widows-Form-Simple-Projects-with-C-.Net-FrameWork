using Guna.UI2.WinForms;
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
        List<clsUsers> UsersData = new List<clsUsers>(); 
        List<clsUsers> SearchedData = new List<clsUsers>();
        
        private void frmShowUsersList_Load(object sender, EventArgs e)
        {
             UsersData = clsUsers.GetUsersList();
            DesplayDataInGrid(DataGridUsersList, UsersData);
            txtSearch.PlaceholderText = "search by Acc Number";
        }

        private void DesplayDataInGrid(Guna2DataGridView Grid,List<clsUsers> U)
        {
            Grid.Rows.Clear();
            if (U != null && U.Count > 0)
            {
                foreach (clsUsers User in U)
                {
                    Grid.Rows.Add(User._FirstName, User._LastName, User._Email, User._Phone, User._AccountNumber, User._Password, User._Permessions);
                }
                //DataGridUsersList.DataSource = UsersData;
                // DataGridUsersList.Refresh();
            }
            else
            {
                MessageBox.Show("No users data available to display.");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text != "")
            {
                foreach (clsUsers U in UsersData)
                {
                    if (U._AccountNumber.Contains(txtSearch.Text))
                    {
                        SearchedData.Add(U);
                    }
                }
                DesplayDataInGrid(DataGridUsersList, SearchedData);

            }
            else
            {
                SearchedData.Clear();
                DesplayDataInGrid(DataGridUsersList, UsersData);
            }
            SearchedData.Clear();
        }
    }
}
