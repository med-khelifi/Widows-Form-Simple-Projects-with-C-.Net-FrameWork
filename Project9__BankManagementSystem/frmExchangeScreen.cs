using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project9__BankManagementSystem.clsBankClient;

namespace Project9__BankManagementSystem
{
    public partial class frmExchangeScreen : Form
    {
        public frmExchangeScreen()
        {
            InitializeComponent();
            InitializeControls();
        }

        bool isCurrency1Found = false, isCurrency2Found = false;
        double Amount = 0;

        private void InitializeControls()
        {
            txtSearchCurrFrom.PlaceholderText = "Search Currency Code";
            txtSearchCurrTo.PlaceholderText = "Search Currency Code";
            
            txtCurrFromName.PlaceholderText = "Curr Name";
            txtCurrToName.PlaceholderText = "Curr Name";

            txtCurrToCode.PlaceholderText = "Code";
            txtCurrFromCode.PlaceholderText = "Code";

            txtCurrFromRate.PlaceholderText = "Rate";
            txtCurrToCode.PlaceholderText = "Rate";

            txtInputAmount.PlaceholderText = "Input Amount";
            txtIOutputAmount.PlaceholderText = "Output Amount";
        }

        clsCurrecy Curr1 = new clsCurrecy();
        clsCurrecy Curr2 = new clsCurrecy();
        private void ClearTxtBoxesCurr1()
        {
            txtSearchCurrFrom.Text = "";
            
        }

        private void ClearTxtBoxesCurr2()
        {

            txtSearchCurrTo.Text = "";
        }

        private void FillCurr1TextBoxes(clsCurrecy U)
        {
            txtCurrFromName.Text = U.CurrencyName;
            txtCurrFromCode.Text = U.CurrencyCode;
            txtCurrFromRate.Text = U.Rate.ToString();
       
        }

        private void FillCurr2TextBoxes(clsCurrecy U)
        {
            txtCurrToName.Text = U.CurrencyName;
            txtCurrToCode.Text = U.CurrencyCode;
            txtCurrToRate.Text = U.Rate.ToString();
        }

        private void txtSearchCurrTo_TextChanged(object sender, EventArgs e)
        {
            if ((Curr2 = clsCurrecy.FindByCode(txtSearchCurrTo.Text)) != null)
            {

                isCurrency2Found = true;

                FillCurr2TextBoxes(Curr2);
            }
            else
            {
                isCurrency2Found = false;

                txtCurrToRate.Text = "";
                txtCurrToCode.Text = "";
                txtCurrToName.Text = "Not Found";
            }
            txtInputAmount.Enabled = isCurrency1Found && isCurrency2Found;
        }

        private void txtInputAmount_TextChanged(object sender, EventArgs e)
        {
            double Amount = 0;
            if(txtInputAmount.Text != "" && double.TryParse(txtInputAmount.Text,out Amount))
            {
                txtIOutputAmount.Text = Curr1.ConvertToOtherCurrency(Amount, Curr2).ToString();
            }
            else
            {
                if (txtInputAmount.Text == "")
                    txtIOutputAmount.Text = "";
                else
                    txtIOutputAmount.Text = "Invalid Input";
            }
        }

        private void txtSearchCurrFrom_TextChanged(object sender, EventArgs e)
        {
            if ((Curr1 = clsCurrecy.FindByCode(txtSearchCurrFrom.Text)) != null)
            {
             
                isCurrency1Found = true;

                FillCurr1TextBoxes(Curr1);
            }
            else
            {
                isCurrency1Found = false;

                txtCurrFromRate.Text = "";
                txtCurrFromCode.Text = "";
                txtCurrFromName.Text = "Not Found";
            }
            txtInputAmount.Enabled = isCurrency1Found && isCurrency2Found;
        }

        
    }
}
