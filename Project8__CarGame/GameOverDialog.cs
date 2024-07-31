using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8__CarGame
{
    public partial class GameOverDialog : Form
    {
        
        public GameOverDialog(string Name,int Score)
        {
            InitializeComponent();
            lblPlayerName.Text = "Player : " + Name;
            lblScore.Text = "Score : " + Score;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
    }
}
