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
    public partial class frmShowClientList : Form
    {
        public frmShowClientList()
        {
            InitializeComponent();
        }

        List<clsBankClient> ClientsData = new List<clsBankClient>();
        List<clsBankClient> SearchedData = new List<clsBankClient>();

      

        private void DesplayDataInGrid(Guna2DataGridView Grid, List<clsBankClient> U)
        {
            Grid.Rows.Clear();
            if (U != null && U.Count > 0)
            {
                foreach (clsBankClient User in U)
                {
                    Grid.Rows.Add(User._FirstName, User._LastName, User._Email, User._Phone, User._AccountNumber, User._PinCode, User._Balance);
                }
                //DataGridUsersList.DataSource = UsersData;
                // DataGridUsersList.Refresh();
            }
            else
            {
               // MessageBox.Show("No Clients data available to display.");
            }
        }

        private void frmShowClientList_Load(object sender, EventArgs e)
        {
            ClientsData = clsBankClient.GetClientsList();
            DesplayDataInGrid(DataGridClientList, ClientsData);
            txtSearch.PlaceholderText = "search by Acc Number";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                foreach (clsBankClient U in ClientsData)
                {
                    if (U._AccountNumber.Contains(txtSearch.Text))
                    {
                        SearchedData.Add(U);
                    }
                }
                DesplayDataInGrid(DataGridClientList, SearchedData);

            }
            else
            {
                SearchedData.Clear();
                DesplayDataInGrid(DataGridClientList, ClientsData);
            }
            SearchedData.Clear();
        }
    }
}
