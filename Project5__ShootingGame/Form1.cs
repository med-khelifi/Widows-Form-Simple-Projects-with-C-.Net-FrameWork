using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project5__ShootingGame
{
    public partial class Form1 : Form
    {

        private void PlayerMovement()
        {
            if (movingLeft && pbPleyer.Left >= 20)
            {
                pbPleyer.Left -= MovementSpeed;
            }

            if (movingRight && pbPleyer.Right <= 480)
            {
                pbPleyer.Left += MovementSpeed;
            }

            if (movingForward && pbPleyer.Top >= 150)
            {
                pbPleyer.Top -= MovementSpeed;
            }

            if (movingBackword && pbPleyer.Bottom <= 430)
            {
                pbPleyer.Top += MovementSpeed;
            }
        }

        private void EnemyMovement()
        {
            Random rd = new Random();


            if (pbAlien.Top >= 500)
            {
                pbAlien.Location= new Point( rd.Next(20,480),0);
            }
            if (pbShip.Top >= 500)
            {
                pbShip.Location = new Point(rd.Next(20, 480),0);
            }
            pbAlien.Top += AlienSped;
            pbShip.Top += ShipSpeed;
        }

        private void ShootBullet()
        {
                PictureBox Bullet = new PictureBox();
                Bullet.Image = Properties.Resources.bullet_img;
                Bullet.SizeMode = PictureBoxSizeMode.AutoSize;
                Bullet.BackColor = System.Drawing.Color.Transparent;
                Bullet.Left = pbPleyer.Left + 15;
                Bullet.Top = pbPleyer.Top - 30;
                Bullet.Tag = "Bullet";
                this.Controls.Add(Bullet);
                Bullet.BringToFront();
            
        }
        
       private void BulletMovement()
        {
            foreach (Control b in this.Controls)
            {
                if(b is PictureBox && b.Tag == "Bullet")
                {
                    b.Top -= 15;
                    if(b.Top <= 100)
                    {
                        this.Controls.Remove(b);
                    } 
                }
            }
        }

        /*
        private void MovingStars()
        {

            /*
             j.Top += 10;
            if(j.Top>400)
                {
                 j.Top = 0;
                }
             
            pbStars1.Top += 10;
            pbStars2.Top += 10;
            if (pbStars1.Top > 450)
            {
                pbStars1.Top = 0;
            }

            if (pbStars2.Top > 450)
            {
                pbStars1.Top = 0;
            }
           
        }
*/

        void MovingStar()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "stars")
                {
                    j.Top += 10;
                    if (j.Top > 400)
                    {
                        j.Top = 0;
                    }
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            lblGameOver.Hide();
        }

        
        bool movingRight, movingLeft, movingForward, movingBackword,Shooting;
        short Score = 0;
        byte AlienSped = 10;
        byte ShipSpeed = 5;
        byte MovementSpeed = 20;
        byte Level = 1,nextLevelUp = 10;
        private void IncreaseLevel()
        {
            if (Score == nextLevelUp)
            {
                Level++;
                lblLevel.Text = "Level : " + Level;
                AlienSped += 5;
                ShipSpeed += 5;
                nextLevelUp += 10;
            }
        }
        private void GameResult()
        {
            foreach (Control Bullet in this.Controls)
            {
                foreach(Control Enemy in this.Controls)
                {
                    if(Bullet is PictureBox && Enemy is PictureBox)
                    {
                        if (Enemy.Tag == "enemy" && Bullet.Tag == "Bullet" && Enemy.Bounds.IntersectsWith(Bullet.Bounds))
                        {

                            ((PictureBox)Bullet).Image= Properties.Resources.explosion;
                            Score++;
                            lblScore.Text = "Score : " + Score;
                            Enemy.Top = 500;

                        }
                    }
                }
            }
        }

        private void EndGame()
        {
            if(pbPleyer.Bounds.IntersectsWith(pbAlien.Bounds) || pbPleyer.Bounds.IntersectsWith(pbShip.Bounds)){
                timer1.Stop();
                lblGameOver.BringToFront();
                lblGameOver.Show();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayerMovement();
            EnemyMovement();
            BulletMovement();
            MovingStar();
            GameResult();
            IncreaseLevel();
            EndGame();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                movingRight = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                movingLeft = true;
            }

            if (e.KeyCode == Keys.Up)
            {
                movingForward = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                movingBackword = true;
            }

            if(e.KeyCode== Keys.Space)
            {
                Shooting = true;
                ShootBullet();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                movingRight = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                movingLeft = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                movingForward = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                movingBackword = false;
            }

            if (e.KeyCode == Keys.Space)
            {
                Shooting = false;
            }
        }
    }
}
