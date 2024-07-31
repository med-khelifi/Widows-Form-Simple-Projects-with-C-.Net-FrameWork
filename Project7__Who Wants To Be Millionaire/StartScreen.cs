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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            lblPlayerName.PlaceholderText = "Enter Your Name";
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if(lblPlayerName.Text == "") 
            {

                for (byte x = 0; x < 5; x++) 
                {
                    lblPlayerName.BorderColor = Color.Red;
                    await Task.Delay(200);
                    lblPlayerName.BorderColor = Color.DarkBlue;
                    await Task.Delay(200);
                }

                return;
            }

            Form1 frm = new Form1(lblPlayerName.Text);
            frm.ShowDialog();
           lblPlayerName.Text = "";
            lblPlayerName.PlaceholderText = "Enter Your Name";
        }
    }
}
