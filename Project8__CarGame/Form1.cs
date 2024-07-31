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
    public partial class Form1 : Form
    {
        //int Score = 0;
        public Form1()
        {
            InitializeComponent();
            pnlHistory.Hide();
            txtPlayerName.PlaceholderText = "Enetr Your Name";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
;        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<PlayerList> Players = PlayerList.GetPlayerList();
            BindingList<PlayerList> BB = new BindingList<PlayerList>(Players);

            //GridPlayerList.DataSource = BB;
            //GridPlayerList.AutoGenerateColumns = true;
            //GridPlayerList.Refresh();
            //ListViewItem XX = new ListViewItem();   
            

            pnlHistory.Show();
            pnlHistory.BringToFront();

            if (Players.Count == 0)
            {
                lblEmpty.Visible = true;
                listView1.Visible = false;
            }
            else
            {
                listView1.Items.Clear();
                foreach (PlayerList i in Players)
                {
                    //listView1.Items.Add(new ListViewItem(i.GetName(), i.GetScore()));
                    ListViewItem XX = new ListViewItem();
                    XX.SubItems.Add(i.GetScore());
                    XX.Text = i.GetName();

                    listView1.Items.Add(XX);
                }

                lblEmpty.Visible = false;
                listView1.Visible = true;
                
            }
        }

        private void btnBackToMainScreen_Click(object sender, EventArgs e)
        {
            pnlHistory.Hide();
        }

        private async void guna2Button2_Click(object sender, EventArgs e)
        {
            if(txtPlayerName.Text == "")
            {
                for(byte x = 0; x < 6;++x)
                {
                    txtPlayerName.BorderColor = Color.Red;
                    await Task.Delay(200);
                    txtPlayerName.BorderColor = Color.White; 
                    await Task.Delay(200);
                }
                return;
            }
            frmGameScreen frm = new frmGameScreen(txtPlayerName.Text);
            frm.ShowDialog();
        }
    }
}
