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
    public partial class frmUpdateCurrencyRateScreen : Form
    {
        public frmUpdateCurrencyRateScreen()
        {
            InitializeComponent();
            InitializeControls();
        }

        bool isCurrencyFound = false, isValidRate = false;
        float Rate;


        private void FillTextBoxes(clsCurrecy U)
        {
            txtCountry.Text = U.Country;
            txtCurrencyCode.Text = U.CurrencyCode;
            txtCurrencyName.Text = U.CurrencyName;
            txtRate.Text = U.Rate.ToString();
        }

        private void InitializeControls()
        {
            txtCountry.PlaceholderText = "Country";
            txtCurrencyCode.PlaceholderText = "Code";
            txtCurrencyName.PlaceholderText = "Currency Name";
            txtRate.PlaceholderText = "Rate";
            
            txtSearchCurrency.PlaceholderText = "Search Currency Code";
         


        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRate.Text) || !float.TryParse(txtRate.Text, out Rate))
            {
                txtRate.BorderColor = Color.Red;
                isValidRate = false;
            }
            else
            {
                txtRate.BorderColor = Color.White;
                isValidRate = true;
            }

            btnUpdateRate.Enabled = isValidRate && isCurrencyFound;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearchCurrency.Text = "";
        }

        clsCurrecy Currency = new clsCurrecy();
        private void txtSearchCurrency_TextChanged(object sender, EventArgs e)
        {
           
            if ((Currency = clsCurrecy.FindByCode(txtSearchCurrency.Text)) != null)
            {
                
                isCurrencyFound = true;

                FillTextBoxes(Currency);
            }
            else
            {
                
                txtCountry.Text = "";
                txtCurrencyCode.Text = "";
                txtCurrencyName.Text = "";
                txtRate.Text = "";
                isCurrencyFound = false;
            }
            
        

             btnUpdateRate.Enabled = isValidRate && isCurrencyFound;
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            if (Currency.UpdateRate(Rate))
            {
                MessageBox.Show("Rate Updated Successfully");
                txtSearchCurrency.Text = "";
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


    }
}