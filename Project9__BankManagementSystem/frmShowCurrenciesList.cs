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
    public partial class frmShowCurrenciesList : Form
    {
        public frmShowCurrenciesList()
        {
            InitializeComponent();
        }

        List<clsCurrecy> Data = new List<clsCurrecy>();
        List<clsCurrecy> SearchedData = new List<clsCurrecy>();



        private void DesplayDataInGrid(Guna2DataGridView Grid, List<clsCurrecy> U)
        {
            Grid.Rows.Clear();
            if (U != null && U.Count > 0)
            {
                foreach (clsCurrecy User in U)
                {
                    Grid.Rows.Add(User.Country, User.CurrencyCode, User.CurrencyName, User.Rate);
                }
                //DataGridUsersList.DataSource = UsersData;
                // DataGridUsersList.Refresh();
            }
            else
            {
                // MessageBox.Show("No Clients data available to display.");
            }
        }

        private void frmShowCurrenciesList_Load(object sender, EventArgs e)
        {
            Data = clsCurrecy.GetCurrenciesList();
            DesplayDataInGrid(DataGridClientList, Data);
            txtSearch.PlaceholderText = "search Currency Code";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                foreach (clsCurrecy U in Data)
                {
                    if (U.CurrencyCode.ToUpper().Contains(txtSearch.Text.ToUpper()))
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
