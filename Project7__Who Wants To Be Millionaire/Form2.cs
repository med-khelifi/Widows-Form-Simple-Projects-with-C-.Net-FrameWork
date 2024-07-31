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
    public partial class CallFriend : Form
    {
        public CallFriend(char CorrectAnswer)
        {
            InitializeComponent();
            ShowScreen(CorrectAnswer);
        }

        private string GetCorrectAnswer(char CorrectAnswer)
        {
            switch (CorrectAnswer)
            {

                case '1':
                    return "Corret Answer is : A ";

                case '2':
                    return "Corret Answer is : B ";

                case '3':
                    return "Corret Answer is : C ";

                case '4':
                    return "Corret Answer is : D ";

                default:
                    return "Corret Answer is : D ";
            }
        }

        private async void ShowScreen(char CorrectAnswer)
        {
            for(byte x = 0; x <5; x++)
            {
                pbPhone.Image = Properties.Resources.icons8_ringer_volume_50;
                await Task.Delay(400);
                pbPhone.Image = Properties.Resources.icons8_ringer_volume_50__1_;
                await Task.Delay(600);
            }

            lblResult.Text = GetCorrectAnswer(CorrectAnswer);
            btnClose.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
