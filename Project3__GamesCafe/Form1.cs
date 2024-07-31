using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Project3__GamesCafe
{
    public partial class Form1 : Form
    {
        DateTime CurrentTimeDate = DateTime.Now;
        byte FreeTable = 6;
        byte ReservedTable = 0;

        short TotalClients = 0;
        double TotalFounds = 0;

        bool isT1Paused = true;
        bool isT2Paused = true;
        bool isT3Paused = true;
        bool isT4Paused = true;
        bool isT5Paused = true;
        bool isT6Paused = true;

        Queue<char> quTables = new Queue<char>();
    
    
        class Duration
        {
            public byte seconds =0;
            public byte minutes = 0;
            public byte hours = 0;

            public string Value()
            {
                return $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
            public void increse()
            {
                seconds++;
                if(seconds == 60)
                {
                    seconds = 0;
                    minutes++;
                }
                if(minutes == 60)
                {
                    minutes = 0;
                    hours++;
                }
            }

            public void Reset()
            {
                seconds = 0;
                minutes = 0;
                hours = 0;
            }
        }

        Duration Table1 = new Duration();
        Duration Table2 = new Duration();
        Duration Table3 = new Duration();
        Duration Table4 = new Duration();
        Duration Table5 = new Duration();
        Duration Table6 = new Duration();
        public Form1()
        {
            InitializeComponent();
            lblTime.Text = CurrentTimeDate.ToShortTimeString();
            lblDate.Text = CurrentTimeDate.ToShortDateString();
            quTables.Enqueue('1');
            quTables.Enqueue('2');
            quTables.Enqueue('3');
            quTables.Enqueue('4');
            quTables.Enqueue('5');
            quTables.Enqueue('6');
        }

        private void Save(Duration D,string ClientName,string TableTag)
        {
            int priceH = (int)nudPricePerHour.Value;
            double PriceM = priceH / 60;
            double priceS = PriceM / 60;

            double Price = D.hours*priceH + D.minutes*PriceM+D.seconds *priceS;

            TreeNode MainNode = new TreeNode("Table "+TableTag);
            TreeNode Client = new TreeNode("Client : " + ClientName);
            TreeNode Time =   new TreeNode("Time   :  " + D.Value());
            string FormatedString = $"Price  : {Price:F3}";
            TreeNode Cost =   new TreeNode(FormatedString);

            MainNode.Nodes.Add(Client);
            MainNode.Nodes.Add(Time);
            MainNode.Nodes.Add(Cost);

            Client.ImageIndex = 2;
            Time.ImageIndex = 0;
            Cost.ImageIndex = 1;
            MainNode.ImageIndex = 3;

            treeView1.Nodes.Add(MainNode);

            ++TotalClients;
            lblTotalClients.Text = TotalClients.ToString();

            TotalFounds += Price;
            lblTotalFounds.Text =  $"{TotalFounds:F3} $";
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (txtClientName.Text == "")
            {
                errorProvider1.SetError(txtClientName, "Plese Enter Client Name!!");
                
                return;
            }

            if(quTables.Count == 0)
            {
                MessageBox.Show("NO TABLE LEFT");
                return;
            }

            ReserveTable();
        }

        private void ReserveTable()
        {
            
            ReservedTable++;
            FreeTable--;
            labelFreeTable.Text = FreeTable.ToString();
            labelReservedTables.Text = ReservedTable.ToString();


            switch (quTables.Peek())
            {

                case '1':
                    pTable1.Visible = true;
                    isT1Paused = false;
                    lblClientNameTable1.Text = txtClientName.Text;
                    lblT1Time.Text = "00:00:00";
                    Table1Start.Enabled = false;
                    quTables.Dequeue();
                    break;

                case '2':
                    pTable2.Visible = true;
                    isT2Paused = false;
                    lblClientNameTable2.Text = txtClientName.Text;
                    lblT2Time.Text = "00:00:00";
                    Table2Start.Enabled = false;
                    quTables.Dequeue();
                    break;

                case '3':
                    pTable3.Visible = true;
                    isT3Paused = false;
                    lblClientNameTable3.Text = txtClientName.Text;
                    lblT3Time.Text = "00:00:00";
                    Table3Start.Enabled = false;
                    quTables.Dequeue();
                    break;

                case '4':
                    pTable4.Visible = true;
                    isT4Paused = false;
                    lblClientNameTable4.Text = txtClientName.Text;
                    lblT4Time.Text = "00:00:00";
                    Table4Start.Enabled = false;
                    quTables.Dequeue();
                    break;

                case '5':
                    pTable5.Visible = true;
                    isT5Paused = false;
                    lblClientNameTable5.Text = txtClientName.Text;
                    lblT5Time.Text = "00:00:00";
                    Table5Start.Enabled = false;
                    quTables.Dequeue();
                    break;


                case '6':
                    pTable6.Visible = true;
                    isT6Paused = false;
                    lblClientNameTable6.Text = txtClientName.Text;
                    lblT6Time.Text = "00:00:00";
                    Table6Start.Enabled = false;
                    quTables.Dequeue();
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isT1Paused)
            {
                Table1.increse();
                lblT1Time.Text = Table1.Value();
            }

            if (!isT2Paused)
            {
                Table2.increse();
                lblT2Time.Text = Table2.Value();
            }

            if (!isT3Paused)
            {
                Table3.increse();
                lblT3Time.Text = Table3.Value();
            }

            if (!isT4Paused)
            {
                Table4.increse();
                lblT4Time.Text = Table4.Value();
            }

            if (!isT5Paused)
            {
                Table5.increse();
                lblT5Time.Text = Table5.Value();
            }

            if (!isT6Paused)
            {
                Table6.increse();
                lblT6Time.Text = Table6.Value();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isT1Paused = true;
            Table1Start.Enabled = true;
            Table1Pause.Enabled = false;
        }

        private void Table1Start_Click(object sender, EventArgs e)
        {
            isT1Paused = false;
            Table1Start.Enabled = false;
            Table1Pause.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save(Table1, lblClientNameTable1.Text, pTable1.Tag.ToString());
            isT1Paused = true;
            Table1.Reset();
            lblClientNameTable1.Text = "---";
            lblT1Time.Text = Table1.Value();
            quTables.Enqueue('1');
            ReservedTable--;
            FreeTable++;
            labelFreeTable.Text = FreeTable.ToString();
            labelReservedTables.Text = ReservedTable.ToString();
        }

        private void Table2End_Click(object sender, EventArgs e)
        {
            Save(Table2, lblClientNameTable2.Text, pTable2.Tag.ToString());
            isT2Paused = true;
            Table2.Reset();
            lblClientNameTable2.Text = "---";
            lblT2Time.Text = Table2.Value();
            quTables.Enqueue('2');
            ReservedTable--;
            FreeTable++;
            labelFreeTable.Text = FreeTable.ToString();
            labelReservedTables.Text = ReservedTable.ToString();
        }

        private void Table3End_Click(object sender, EventArgs e)
        {
            Save(Table3, lblClientNameTable3.Text, pTable3.Tag.ToString());
            isT3Paused = true;
            Table3.Reset();
            lblClientNameTable3.Text = "---";
            lblT3Time.Text = Table3.Value();
            quTables.Enqueue('3');
            ReservedTable--;
            FreeTable++;
            labelFreeTable.Text = FreeTable.ToString();
            labelReservedTables.Text = ReservedTable.ToString();
        }

        private void Table4End_Click(object sender, EventArgs e)
        {
            Save(Table4, lblClientNameTable4.Text, pTable4.Tag.ToString());
            isT4Paused = true;
            Table4.Reset();
            lblClientNameTable4.Text = "---";
            lblT4Time.Text = Table4.Value();
            quTables.Enqueue('4');
            ReservedTable--;
            FreeTable++;
            labelFreeTable.Text = FreeTable.ToString();
            labelReservedTables.Text = ReservedTable.ToString();
        }

        private void Table5End_Click(object sender, EventArgs e)
        {
            Save(Table5, lblClientNameTable5.Text, pTable5.Tag.ToString());
            isT5Paused = true;
            Table5.Reset();
            lblClientNameTable5.Text = "---";
            lblT5Time.Text = Table5.Value();
            quTables.Enqueue('5');
            ReservedTable--;
            FreeTable++;
            labelFreeTable.Text = FreeTable.ToString();
            labelReservedTables.Text = ReservedTable.ToString();
        }

        private void Table6End_Click(object sender, EventArgs e)
        {
            Save(Table6, lblClientNameTable6.Text, pTable6.Tag.ToString());
            isT6Paused = true;
            Table6.Reset();
            lblClientNameTable6.Text = "---";
            lblT6Time.Text = Table6.Value();
            quTables.Enqueue('6');
            ReservedTable--;
            FreeTable++;
            labelFreeTable.Text = FreeTable.ToString();
            labelReservedTables.Text = ReservedTable.ToString();
        }

        private void Table2Start_Click(object sender, EventArgs e)
        {
            isT2Paused = false;
            Table2Start.Enabled = false;
            Table2Pause.Enabled = true;
        }

        private void Table3Start_Click(object sender, EventArgs e)
        {
            isT3Paused = false;
            Table3Start.Enabled = false;
            Table3Pause.Enabled = true;
        }

        private void Table4Start_Click(object sender, EventArgs e)
        {
            isT4Paused = false;
            Table4Start.Enabled = false;
            Table4Pause.Enabled = true;
        }

        private void Table5Start_Click(object sender, EventArgs e)
        {
            isT5Paused = false;
            Table5Start.Enabled = false;
            Table5Pause.Enabled = true;
        }

        private void Table6Start_Click(object sender, EventArgs e)
        {
            isT6Paused = false;
            Table6Start.Enabled = false;
            Table6Pause.Enabled = true;
        }

        private void Table2Pause_Click(object sender, EventArgs e)
        {
            isT2Paused = true;
            Table2Start.Enabled = true;
            Table2Pause.Enabled = false;
        }

        private void Table3Pause_Click(object sender, EventArgs e)
        {
            isT3Paused = true;
            Table3Start.Enabled = true;
            Table3Pause.Enabled = false;
        }

        private void Table4Pause_Click(object sender, EventArgs e)
        {
            isT4Paused = true;
            Table4Start.Enabled = true;
            Table4Pause.Enabled = false;
        }

        private void Table5Pause_Click(object sender, EventArgs e)
        {
            isT5Paused = true;
            Table5Start.Enabled = true;
            Table5Pause.Enabled = false;
        }

        private void Table6Pause_Click(object sender, EventArgs e)
        {
            isT6Paused = true;
            Table6Start.Enabled = true;
            Table6Pause.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(txtClientName.Text == "")
            {
                errorProvider1.SetError(txtClientName, "Enter Client Name");

                return;
            }
            if (FreeTable == 0)
            {
                MessageBox.Show("No Tabel Left");
                return; 
            }
            ReserveTable();
            txtClientName.Text = "";
        }

    }
}
