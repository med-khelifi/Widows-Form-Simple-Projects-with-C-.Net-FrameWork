namespace Project5__ShootingGame
{
    partial class Form1
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
            this.pbPleyer = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbAlien = new System.Windows.Forms.PictureBox();
            this.pbShip = new System.Windows.Forms.PictureBox();
            this.pbStars1 = new System.Windows.Forms.PictureBox();
            this.pbStars2 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPleyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPleyer
            // 
            this.pbPleyer.Image = global::Project5__ShootingGame.Properties.Resources.player_img;
            this.pbPleyer.Location = new System.Drawing.Point(156, 384);
            this.pbPleyer.Name = "pbPleyer";
            this.pbPleyer.Size = new System.Drawing.Size(46, 45);
            this.pbPleyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbPleyer.TabIndex = 0;
            this.pbPleyer.TabStop = false;
            this.pbPleyer.Tag = "player";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbAlien
            // 
            this.pbAlien.Image = global::Project5__ShootingGame.Properties.Resources.alien_gif;
            this.pbAlien.Location = new System.Drawing.Point(20, 50);
            this.pbAlien.Name = "pbAlien";
            this.pbAlien.Size = new System.Drawing.Size(60, 60);
            this.pbAlien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbAlien.TabIndex = 1;
            this.pbAlien.TabStop = false;
            this.pbAlien.Tag = "enemy";
            // 
            // pbShip
            // 
            this.pbShip.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbShip.Image = global::Project5__ShootingGame.Properties.Resources.ship_gif;
            this.pbShip.Location = new System.Drawing.Point(272, 62);
            this.pbShip.Name = "pbShip";
            this.pbShip.Size = new System.Drawing.Size(50, 27);
            this.pbShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbShip.TabIndex = 2;
            this.pbShip.TabStop = false;
            this.pbShip.Tag = "enemy";
            // 
            // pbStars1
            // 
            this.pbStars1.Image = global::Project5__ShootingGame.Properties.Resources.Stars_img;
            this.pbStars1.Location = new System.Drawing.Point(-1, 0);
            this.pbStars1.Name = "pbStars1";
            this.pbStars1.Size = new System.Drawing.Size(482, 244);
            this.pbStars1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStars1.TabIndex = 3;
            this.pbStars1.TabStop = false;
            this.pbStars1.Tag = "stars";
            // 
            // pbStars2
            // 
            this.pbStars2.Image = global::Project5__ShootingGame.Properties.Resources.Stars_img;
            this.pbStars2.Location = new System.Drawing.Point(-1, 250);
            this.pbStars2.Name = "pbStars2";
            this.pbStars2.Size = new System.Drawing.Size(482, 211);
            this.pbStars2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStars2.TabIndex = 4;
            this.pbStars2.TabStop = false;
            this.pbStars2.Tag = "stars";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(107, 25);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score : 0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.Tomato;
            this.lblGameOver.Location = new System.Drawing.Point(149, 175);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(191, 37);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "Game-Over";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblLevel.Location = new System.Drawing.Point(139, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(89, 25);
            this.lblLevel.TabIndex = 7;
            this.lblLevel.Text = "Level 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbShip);
            this.Controls.Add(this.pbAlien);
            this.Controls.Add(this.pbPleyer);
            this.Controls.Add(this.pbStars1);
            this.Controls.Add(this.pbStars2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPleyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStars2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPleyer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbAlien;
        private System.Windows.Forms.PictureBox pbShip;
        private System.Windows.Forms.PictureBox pbStars1;
        private System.Windows.Forms.PictureBox pbStars2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblLevel;
    }
}

