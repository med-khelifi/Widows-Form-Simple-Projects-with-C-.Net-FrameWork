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
    public partial class frmGameScreen : Form
    {
        // Variables to manage game speed, player and traffic movement
        byte PlayerSpeed , TraficSpeed , RoadSpeed, Car,Level;
        bool GoLeft, GoRight;
        int Score,NextScore;
        
        Random CarPosition = new Random();
        Random CarType = new Random();

        string PlayerName;

        public frmGameScreen(string playerName)
        {
            InitializeComponent();
            this.PlayerName = playerName;
            RestartGame();  
        }

        private void GameTimerTick(object sender, EventArgs e)
        {
            Score++;
            lblScore.Text = "Score : " + Score.ToString();
            lblCar.Text = "Car : " + Car.ToString();
            
            

            MovePlayer();
            MoveRoad();
            SpawnCars(pbAiLeft);
            SpawnCars(pbAiRight);
            CheckGameEnd();
            IncreaseLevel();
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                GoLeft = true;
            if (e.KeyCode == Keys.Right)
                GoRight = true;
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                GoLeft = false;
            if (e.KeyCode == Keys.Right)
                GoRight = false;
        }

        private void MovePlayer()
        {
            if (GoRight && pbPlayer.Right < 330)
            {
                pbPlayer.Left += PlayerSpeed;
            }
            if (GoLeft && pbPlayer.Left > 30)
            {
                pbPlayer.Left -= PlayerSpeed;
            }
        }

        private void MoveRoad()
        {
            Road1.Top += RoadSpeed;
            Road2.Top += RoadSpeed;

            if (Road2.Top > 480)
                Road2.Top = -480;
            if (Road1.Top > 480)
                Road1.Top = -480;
        }

        private async void RestartGame()
        {
            timer1.Stop();
            PlayerSpeed = 20;
            TraficSpeed = 13;
            RoadSpeed = 10;
            Score = 0;
            NextScore = 500;
            Car = 0;
            Level = 1;

            GoLeft = false;
            GoRight = false;

            lblCar.Text = "Car : 0";
            lblScore.Text = "Score : 0";
            lblTime.Text = "5";
            LblLevel.Text = "Level : 1";
            lblPlayerName.Text = PlayerName;

            lblTime.Show();
            lblTime.BringToFront();

            pbPlayer.Location = new Point(164, 365);
            pbPlayer.Visible = true;
            pbExplotion.Visible = false;

            pbAiLeft.Top = -250;
            pbAiRight.Top = -25;

            for (byte i = 5; i > 0; i--)
            {
                lblTime.Text = i.ToString();
                await Task.Delay(1000);
            }

            lblTime.Hide();
            timer1.Start();

            
        }

        //private void frmGameScreen_Load(object sender, EventArgs e)
        //{
        //    RestartGame();
        //}

        private void SpawnCars(PictureBox Pic)
        {
            Pic.Top += TraficSpeed;

            if (Pic.Top > 500)
            {
                Car++;
                Pic.Top = CarPosition.Next(100, 600) * -1;

                if (Pic.Tag.ToString() == "1")
                    Pic.Left = CarPosition.Next(25, 125);
                else
                    Pic.Left = CarPosition.Next(160, 290);

                ChangeCar(Pic, (byte)CarType.Next(1, 9));
            }
        }
        private void ChangeCar(PictureBox Pic, byte Num)
        {
            switch (Num)
            {
                case 1: Pic.Image = Properties.Resources.ambulance; break;
                case 2: Pic.Image = Properties.Resources.carGreen; break;
                case 3: Pic.Image = Properties.Resources.carYellow; break;
                case 4: Pic.Image = Properties.Resources.carGrey; break;
                case 5: Pic.Image = Properties.Resources.carPink; break;
                case 6: Pic.Image = Properties.Resources.CarRed; break;
                case 7: Pic.Image = Properties.Resources.TruckBlue; break;
                case 8: Pic.Image = Properties.Resources.TruckWhite; break;
            }
        }
        private async void CheckGameEnd()
        {
            if (pbPlayer.Bounds.IntersectsWith(pbAiLeft.Bounds) || pbPlayer.Bounds.IntersectsWith(pbAiRight.Bounds))
            {
                timer1.Stop();
                PlaySound();
                pbExplotion.Location = pbPlayer.Location;
                pbPlayer.BackColor = System.Drawing.Color.Transparent;
               // pbExplotion.BackColor = Color.Transparent;
                pbExplotion.Visible = true;
                pbPlayer.Visible = false;
                pbExplotion.BringToFront();
                await Task.Delay(2000);
                PlayAgain_MainScreen();

            }
        }
        private void PlayAgain_MainScreen()
        {
            GameOverDialog frm = new GameOverDialog(PlayerName, Score);
            frm.ShowDialog();
            PlayerList.AddPlayer(new PlayerList(PlayerName, Score));
            if (frm.DialogResult == DialogResult.Cancel)
            {
                frm.Close();
                this.Close();
            }
            if(frm.DialogResult == DialogResult.Yes)
            {
                frm.Close();
                RestartGame();
            }

            
        }
        private void PlaySound()
        {
            try
            {
                System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(@"C:\Users\hp\Desktop\Wal3a\Coding\ProgrammingAdvices\course_14 C# Level1\Projects\Project8__CarGame\hit.wav");
                Sound.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }
        private void IncreaseLevel()
        {
            if(Score > NextScore)
            {
                PlayerSpeed += 5;
                TraficSpeed += 5;
                RoadSpeed += 5;
                NextScore += 500;
                ++Level;
                LblLevel.Text = "Level : " + Level;

            }
        }
    }
}
