using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1__FlappyBird
{
    public partial class Form1 : Form
    {

        short GameSpeed = 5;
        short Gravity = 8;
        short Score = 0;
        bool GameOver = false;

        private bool CheckendGame()
        {
            if (pbBird.Bounds.IntersectsWith(pbTopPipe.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbDownPipe.Bounds) ||
                pbBird.Bounds.IntersectsWith(pbGround.Bounds) || pbBird.Top < -25)
            {
                return true;
            }
            else return false;
        }
        
        private void RestartGame()
        {
            pbBird.Location = new Point(17,117);
            GameTimer.Enabled = true;
            GameOver = true;
            pbDownPipe.Location = new Point(168, 284); ;
            pbTopPipe.Location = new Point(416, -5); 

            Score = 0;
            lblScore.Text = "Score : 0";
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        Random rd ;
        private void GameTimerEvent(object sender, EventArgs e)
        {
            pbBird.Top += Gravity;
            pbDownPipe.Left -= GameSpeed;
            pbTopPipe.Left -= GameSpeed;
            lblScore.Text = "Score : " + Score.ToString();

            rd = new Random();
            if (pbTopPipe.Left < -100)
            {
                pbTopPipe.Left = rd.Next(400,520);
                Score++;
            }

            if (pbDownPipe.Left < -100)
            {
                pbDownPipe.Left = rd.Next(400, 520);
                Score++;
            }
           

            if (CheckendGame())
            {
                EndGame();  
            }
        }
        private void GameKeyUP(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space )
            {
                Gravity =5;
            }

            if(e.KeyCode == Keys.S)
            {
                label1.Visible = false;
                GameTimer.Enabled = true;
            }
        }
        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                Gravity = -5;
            }
        }
        private void EndGame()
        {
            GameOver = true;
            GameTimer.Enabled = false;
            if (MessageBox.Show($"Your Score is :  {Score} \nDo You Play Again ?", "Game Over", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                RestartGame();
            }
            else
                Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //GameTimer.Stop();
        }
    }

}
