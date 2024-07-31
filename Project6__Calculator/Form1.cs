using System;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6__Calculator
{
    public partial class Form1 : Form
    {
        double Number1 = 0;
        double Result = 0;
        string Operation = "",PreviousOP ="";
        private void PerformOperation()
        {
            //if (Operation =="") return;
            if(Operation == "" && Result != 0)
            {
                Result = (PreviousOP == "+" ? Result + Result :
                (PreviousOP == "-" ? Result - Result :
                (PreviousOP == "/" ? Result / Result :
                (PreviousOP == "*" ? Result * Result : Result))));
                lblDownNumbers.Text = Result.ToString();
                return;
            }
            PreviousOP = Operation;    

            switch (Operation)
            { 
                case "+":
                    lblUpNumbers.Text += lblDownNumbers.Text + '=';
                    Result = Number1 + Convert.ToDouble(lblDownNumbers.Text);
                    lblDownNumbers.Text = Result.ToString();
                    Number1 = 0;
                    Operation = "";
                    break;

                case "-":
                    lblUpNumbers.Text += lblDownNumbers.Text + '=';
                    Result = Number1 - Convert.ToDouble(lblDownNumbers.Text);
                    lblDownNumbers.Text = Result.ToString();
                    Number1 = 0;
                    Operation = "";
                    break;

                case "*":
                    lblUpNumbers.Text += lblDownNumbers.Text + '=';
                    Result = Number1 * Convert.ToDouble(lblDownNumbers.Text);
                    lblDownNumbers.Text = Result.ToString();
                    Number1 = 0;
                    Operation = "";
                    break;

                case "/":
                    lblUpNumbers.Text += lblDownNumbers.Text + '=';
                    if(Convert.ToDouble(lblDownNumbers.Text) != 0)
                        Result = Number1 / Convert.ToDouble(lblDownNumbers.Text);
                    lblDownNumbers.Text = Result.ToString();
                    Number1 = 0;
                    Operation = "";
                    break;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if( !lblDownNumbers.Text.Contains('.') && lblDownNumbers.Text != "")
            {
                lblDownNumbers.Text = lblDownNumbers.Text + '.';
            }
        }
        
        private void guna2Button18_Click(object sender, EventArgs e)
        {
            if (lblDownNumbers.Text != "")
                lblDownNumbers.Text = lblDownNumbers.Text.Substring(0, lblDownNumbers.Text.Length - 1);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nums_Cliked(object sender, EventArgs e)
        {
            lblDownNumbers.Text += ((Guna2Button)sender).Tag;
        }

        private void OperationsButtonsClicked(object sender, EventArgs e)
        {
            if(lblDownNumbers.Text != "") 
            {
                Number1 = Convert.ToDouble(lblDownNumbers.Text);
                Operation = ((Guna2Button)sender).Tag.ToString();
                lblUpNumbers.Text = lblDownNumbers.Text + Operation;
                lblDownNumbers.Text = "";
            }
           
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            PerformOperation();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            lblDownNumbers.Text = "";
            lblUpNumbers.Text = "";
            Operation = "";
            Number1 = 0;
            PreviousOP = "";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (lblDownNumbers.Text != "")
            {
                lblDownNumbers.Text =((Convert.ToDouble(lblDownNumbers.Text) * -1).ToString());
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            if (lblDownNumbers.Text != "")
            {
                lblDownNumbers.Text = (Convert.ToDouble(lblDownNumbers.Text) * Convert.ToDouble(lblDownNumbers.Text)).ToString();
            }
                
        }
    }
}
