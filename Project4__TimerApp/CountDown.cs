using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4__TimerApp
{
    public partial class CountDown : Form
    {
        public CountDown()
        {
            InitializeComponent();
        }

        TimeSpan CountDownTimer;
        bool TimerOn = false;

        private void udHours_ValueChanged(object sender, EventArgs e)
        {
            CountDownTimer = new TimeSpan((byte)udHours.Value, (byte)udminutes.Value, (byte)udsecond.Value);
            lblCurrentTime.Text = CountDownTimer.ToString();
            if (!(CountDownTimer.TotalSeconds == 0))
                pbarTime.Maximum = (int)CountDownTimer.TotalSeconds;
            else
                pbarTime.Maximum = 100;
            pbarTime.Value = pbarTime.Maximum;
        }

        private void pbPlayPause_Click(object sender, EventArgs e)
        {
            if (udHours.Value == 0 && udminutes.Value == 0 && udsecond.Value == 0) return;
  
            if (TimerOn)
            {
                timer1.Stop();
                pbPlayPause.Image = Properties.Resources._001_play;

                TimerOn = false;

                udHours.Enabled = true;
                udminutes.Enabled = true;
                udsecond.Enabled = true;

            }
            else
            {
                timer1.Start();
                pbPlayPause.Image = Properties.Resources._002_stop;

              
                TimerOn = true;

                udHours.Enabled = false;
                udminutes.Enabled = false;
                udsecond.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountDownTimer.TotalMilliseconds == 0 && TimerOn)
            {
                timer1.Stop();
                pbPlayPause.Image = Properties.Resources._001_play;
                CountDownTimer = new TimeSpan((byte)udHours.Value, (byte)udminutes.Value, (byte)udsecond.Value);
                pbarTime.Value = pbarTime.Maximum;
                lblCurrentTime.Text = CountDownTimer.ToString();

                TimerOn = false;

                udHours.Enabled = true;
                udminutes.Enabled = true;
                udsecond.Enabled = true;
                return;
            }

            if (TimerOn ) {

                pbarTime.Value = (int)CountDownTimer.TotalSeconds - 1;
                CountDownTimer = CountDownTimer.Subtract(TimeSpan.FromSeconds(1));
                lblCurrentTime.Text = CountDownTimer.ToString();
            }
            
        }
    }
}
