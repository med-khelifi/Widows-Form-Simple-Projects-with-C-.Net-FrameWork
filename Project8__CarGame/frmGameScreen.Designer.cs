namespace Project8__CarGame
{
    partial class frmGameScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pbExplotion = new System.Windows.Forms.PictureBox();
            this.pbAiRight = new System.Windows.Forms.PictureBox();
            this.pbAiLeft = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.Road2 = new System.Windows.Forms.PictureBox();
            this.Road1 = new System.Windows.Forms.PictureBox();
            this.LblLevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAiRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAiLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pbExplotion);
            this.panel1.Controls.Add(this.pbAiRight);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pbAiLeft);
            this.panel1.Controls.Add(this.pbPlayer);
            this.panel1.Controls.Add(this.Road2);
            this.panel1.Controls.Add(this.Road1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 480);
            this.panel1.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(141, 121);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(68, 75);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "5";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.GameTimerTick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(371, 256);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 22);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score : 0";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.ForeColor = System.Drawing.Color.White;
            this.lblCar.Location = new System.Drawing.Point(371, 326);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(71, 22);
            this.lblCar.TabIndex = 2;
            this.lblCar.Text = "Car : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(371, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player :";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPlayerName.Location = new System.Drawing.Point(368, 110);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(123, 19);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Mohame khelifi";
            // 
            // pbExplotion
            // 
            this.pbExplotion.BackColor = System.Drawing.Color.Transparent;
            this.pbExplotion.Image = global::Project8__CarGame.Properties.Resources.explosion;
            this.pbExplotion.Location = new System.Drawing.Point(145, 190);
            this.pbExplotion.Name = "pbExplotion";
            this.pbExplotion.Size = new System.Drawing.Size(64, 64);
            this.pbExplotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbExplotion.TabIndex = 2;
            this.pbExplotion.TabStop = false;
            this.pbExplotion.Visible = false;
            // 
            // pbAiRight
            // 
            this.pbAiRight.Image = global::Project8__CarGame.Properties.Resources.carPink;
            this.pbAiRight.Location = new System.Drawing.Point(241, 218);
            this.pbAiRight.Name = "pbAiRight";
            this.pbAiRight.Size = new System.Drawing.Size(50, 100);
            this.pbAiRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAiRight.TabIndex = 2;
            this.pbAiRight.TabStop = false;
            this.pbAiRight.Tag = "2";
            // 
            // pbAiLeft
            // 
            this.pbAiLeft.Image = global::Project8__CarGame.Properties.Resources.carGreen;
            this.pbAiLeft.Location = new System.Drawing.Point(70, 3);
            this.pbAiLeft.Name = "pbAiLeft";
            this.pbAiLeft.Size = new System.Drawing.Size(50, 101);
            this.pbAiLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAiLeft.TabIndex = 2;
            this.pbAiLeft.TabStop = false;
            this.pbAiLeft.Tag = "1";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Image = global::Project8__CarGame.Properties.Resources.carOrange;
            this.pbPlayer.Location = new System.Drawing.Point(164, 365);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(50, 100);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.TabStop = false;
            // 
            // Road2
            // 
            this.Road2.Image = global::Project8__CarGame.Properties.Resources.roadTrack;
            this.Road2.Location = new System.Drawing.Point(0, 0);
            this.Road2.Name = "Road2";
            this.Road2.Size = new System.Drawing.Size(350, 480);
            this.Road2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road2.TabIndex = 1;
            this.Road2.TabStop = false;
            // 
            // Road1
            // 
            this.Road1.Image = global::Project8__CarGame.Properties.Resources.roadTrack;
            this.Road1.Location = new System.Drawing.Point(0, -480);
            this.Road1.Name = "Road1";
            this.Road1.Size = new System.Drawing.Size(350, 480);
            this.Road1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Road1.TabIndex = 0;
            this.Road1.TabStop = false;
            // 
            // LblLevel
            // 
            this.LblLevel.AutoSize = true;
            this.LblLevel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLevel.ForeColor = System.Drawing.Color.White;
            this.LblLevel.Location = new System.Drawing.Point(371, 165);
            this.LblLevel.Name = "LblLevel";
            this.LblLevel.Size = new System.Drawing.Size(88, 22);
            this.LblLevel.TabIndex = 4;
            this.LblLevel.Text = "Lavel : 1";
            // 
            // frmGameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.LblLevel);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyisDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExplotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAiRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAiLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Road1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Road2;
        private System.Windows.Forms.PictureBox Road1;
        private System.Windows.Forms.PictureBox pbAiLeft;
        private System.Windows.Forms.PictureBox pbAiRight;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbExplotion;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label LblLevel;
    }
}