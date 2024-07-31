namespace Project1__FlappyBird
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
            this.pbGround = new System.Windows.Forms.PictureBox();
            this.pbTopPipe = new System.Windows.Forms.PictureBox();
            this.pbDownPipe = new System.Windows.Forms.PictureBox();
            this.pbBird = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGround
            // 
            this.pbGround.Image = global::Project1__FlappyBird.Properties.Resources.ground;
            this.pbGround.Location = new System.Drawing.Point(-11, 487);
            this.pbGround.Name = "pbGround";
            this.pbGround.Size = new System.Drawing.Size(572, 67);
            this.pbGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGround.TabIndex = 0;
            this.pbGround.TabStop = false;
            // 
            // pbTopPipe
            // 
            this.pbTopPipe.Image = global::Project1__FlappyBird.Properties.Resources.pipedown;
            this.pbTopPipe.Location = new System.Drawing.Point(416, -5);
            this.pbTopPipe.Name = "pbTopPipe";
            this.pbTopPipe.Size = new System.Drawing.Size(66, 169);
            this.pbTopPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTopPipe.TabIndex = 1;
            this.pbTopPipe.TabStop = false;
            // 
            // pbDownPipe
            // 
            this.pbDownPipe.Image = global::Project1__FlappyBird.Properties.Resources.pipe;
            this.pbDownPipe.Location = new System.Drawing.Point(168, 284);
            this.pbDownPipe.Name = "pbDownPipe";
            this.pbDownPipe.Size = new System.Drawing.Size(66, 217);
            this.pbDownPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDownPipe.TabIndex = 2;
            this.pbDownPipe.TabStop = false;
            // 
            // pbBird
            // 
            this.pbBird.Image = global::Project1__FlappyBird.Properties.Resources.bird;
            this.pbBird.Location = new System.Drawing.Point(17, 117);
            this.pbBird.Name = "pbBird";
            this.pbBird.Size = new System.Drawing.Size(68, 59);
            this.pbBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBird.TabIndex = 3;
            this.pbBird.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(11, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(131, 32);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score : 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press S to start ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(559, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbGround);
            this.Controls.Add(this.pbBird);
            this.Controls.Add(this.pbDownPipe);
            this.Controls.Add(this.pbTopPipe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUP);
            ((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTopPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDownPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGround;
        private System.Windows.Forms.PictureBox pbTopPipe;
        private System.Windows.Forms.PictureBox pbDownPipe;
        private System.Windows.Forms.PictureBox pbBird;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
    }
}

