using Guna.UI2.WinForms;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1; 
            timer1.Start();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            pbExit.FillColor = Color.Red;
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            pbExit.FillColor = Color.Gold;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime CurrTime = DateTime.Now; // Update CurrTime to the current system time
            lblCurrentTime.Text = CurrTime.ToString("HH:mm:ss tt");
        }
         
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            frmStopWatch frmSW = new frmStopWatch();
            frmSW.Show();
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            CountDown frmSW = new CountDown();
            frmSW.Show();
        }

       
    }
}
