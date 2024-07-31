using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Project4__TimerApp
{
    public partial class frmStopWatch : Form
    {

        public frmStopWatch()
        {
            InitializeComponent();
        }

        Stopwatch sw = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan Elapset = sw.Elapsed;
            lblTime.Text = "Timer : " + string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                Math.Floor(Elapset.TotalHours), Elapset.Minutes, Elapset.Seconds, Elapset.Milliseconds);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sw.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sw.Stop();
        }

        byte x = 0;
        private void btnCapture_Click(object sender, EventArgs e)
        {
            x++;
            listBox1.Items.Add(x + " - " + lblTime.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sw.Stop();
            sw.Reset();
            listBox1.Items.Clear();
            x = 0;
            lblTime.Text = "Timer : 00:00:00:00";
        }
    }
}
