using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7__Who_Wants_To_Be_Millionaire
{
    public partial class AskAudience : Form
    {
        public AskAudience(char CorrectAnswer, bool is50_50Used)
        {
            InitializeComponent();
            ShowScrren(CorrectAnswer, is50_50Used);
        }
       
        private Random rd = new Random(); // Initialize once

        private void GenerateValuesSetValue(char correctAnswer, bool is50_50Used)
        {
            if (is50_50Used)
            {
                byte percentage1 = (byte)rd.Next(0, 101);
                byte percentage2 = (byte)(100 - percentage1);

                if (correctAnswer == '1' || correctAnswer == '4')
                {
                    if (correctAnswer == '1')
                    {
                        P1.Value = Math.Max(percentage1, percentage2);
                        P4.Value = Math.Min(percentage1, percentage2);
                    }
                    else
                    {
                        P4.Value = Math.Max(percentage1, percentage2);
                        P1.Value = Math.Min(percentage1, percentage2);
                    }
                    
                    panelAns1.Visible = true;
                    panelAns4.Visible = true;
                }
                else if (correctAnswer == '2' || correctAnswer == '3')
                {
                    if (correctAnswer == '2')
                    {
                        P2.Value = Math.Max(percentage1, percentage2);
                        P3.Value = Math.Min(percentage1, percentage2);
                    }
                    else
                    {
                        P3.Value = Math.Max(percentage1, percentage2);
                        P2.Value = Math.Min(percentage1, percentage2);
                    }

                    panelAns2.Visible = true;
                    panelAns3.Visible = true;
                }
            }
            else
            {
                // Ensure all panels are visible
                panelAns1.Visible = true;
                panelAns2.Visible = true;
                panelAns3.Visible = true;
                panelAns4.Visible = true;

                // Assign values to the progress bars
                switch (correctAnswer)
                {
                    case '1':
                        P1.Value = 80;
                        P2.Value = 10;
                        P3.Value = 2;
                        P4.Value = 8;
                        break;
                    case '2':
                        P1.Value = 20;
                        P2.Value = 75;
                        P3.Value = 2;
                        P4.Value = 3;
                        break;
                    case '3':
                        P1.Value = 0;
                        P2.Value = 2;
                        P3.Value = 92;
                        P4.Value = 8;
                        break;
                    case '4':
                        P1.Value = 3;
                        P2.Value = 2;
                        P3.Value = 11;
                        P4.Value = 85;
                        break;
                }

                // Ensure the progress bars are refreshed to show the new values
                P1.Refresh();
                P2.Refresh();
                P3.Refresh();
                P4.Refresh();
            }
        }


        private async void ShowScrren(char CorrectAnswer, bool is50_50Used)
        {
            await Task.Delay(3000);
            btnClose.Visible = true;
            lblPlzWait.Visible = false;
            GenerateValuesSetValue(CorrectAnswer, is50_50Used);
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}