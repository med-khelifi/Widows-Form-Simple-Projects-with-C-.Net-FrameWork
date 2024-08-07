using Guna.UI2.WinForms;
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
    public partial class frmShowLoggingHistory : Form
    {
        public frmShowLoggingHistory()
        {
            InitializeComponent();
        }

        List<clsUsers.stLoginhistory> Data = new List<clsUsers.stLoginhistory>();
        List<clsUsers.stLoginhistory> SearchedData = new List<clsUsers.stLoginhistory>();



        private void DesplayDataInGrid(Guna2DataGridView Grid, List<clsUsers.stLoginhistory> U)
        {
            Grid.Rows.Clear();
            if (U != null && U.Count > 0)
            {
                foreach (clsUsers.stLoginhistory D in U)
                {
                    Grid.Rows.Add(D.Date, D.UserName, D.Password, D.Permissions);
                }
                //DataGridUsersList.DataSource = UsersData;
                // DataGridUsersList.Refresh();
            }
            else
            {
                // MessageBox.Show("No Clients data available to display.");
            }
        }

        private void frmShowLoggingHistory_Load(object sender, EventArgs e)
        {
            Data = clsUsers.GetLoggingHistoryData();
            DesplayDataInGrid(DataGridClientList, Data);
            txtSearch.PlaceholderText = "search by Acc Number";
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                foreach (clsUsers.stLoginhistory U in Data)
                {
                    if (U.UserName.Contains(txtSearch.Text))
                    {
                        SearchedData.Add(U);
                    }
                }
                DesplayDataInGrid(DataGridClientList, SearchedData);

            }
            else
            {
                SearchedData.Clear();
                DesplayDataInGrid(DataGridClientList, Data);
            }
            SearchedData.Clear();
        }
    }
}
