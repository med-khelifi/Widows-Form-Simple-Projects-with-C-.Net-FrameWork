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
    public partial class frmShowTransferLogsList : Form
    {
        public frmShowTransferLogsList()
        {
            InitializeComponent();
        }

        List<clsBankClient.stTransfer> Data = new List<clsBankClient.stTransfer>();
        List<clsBankClient.stTransfer> SearchedData = new List<clsBankClient.stTransfer>();



        private void DesplayDataInGrid(Guna2DataGridView Grid, List<clsBankClient.stTransfer> U)
        {
            Grid.Rows.Clear();
            if (U != null && U.Count > 0)
            {
                foreach (clsBankClient.stTransfer D in U)
                {
                    Grid.Rows.Add(D.Date, D.SenderAccount, D.ReceiverAccount, D.Amount);
                }
                //DataGridUsersList.DataSource = UsersData;
                // DataGridUsersList.Refresh();
            }
            else
            {
                // MessageBox.Show("No Clients data available to display.");
            }
        }

        private void frmShowTransferLogsList_Load(object sender, EventArgs e)
        {
            Data = clsBankClient.GetTransferOperationList();
            DesplayDataInGrid(DataGridClientList, Data);
            txtSearch.PlaceholderText = "search by Sender Acc Number";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                foreach (clsBankClient.stTransfer U in Data)
                {
                    if (U.SenderAccount.Contains(txtSearch.Text))
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
