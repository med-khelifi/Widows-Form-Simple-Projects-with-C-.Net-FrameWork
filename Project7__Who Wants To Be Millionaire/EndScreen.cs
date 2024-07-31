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
    public partial class EndScreen : Form
    { 
        public EndScreen(string Amount,string PlayerName)
        {
            InitializeComponent();


            lblPlerName.Text = PlayerName;
            lblAmount.Text = Amount;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
