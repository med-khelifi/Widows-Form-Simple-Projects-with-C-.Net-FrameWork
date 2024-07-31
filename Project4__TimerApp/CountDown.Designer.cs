
namespace Project4__TimerApp
{
    partial class CountDown
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
            this.pbarTime = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pbPlayPause = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.udHours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.udsecond = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.udminutes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbarTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udsecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udminutes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbarTime
            // 
            this.pbarTime.Controls.Add(this.pbPlayPause);
            this.pbarTime.Controls.Add(this.lblCurrentTime);
            this.pbarTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.pbarTime.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pbarTime.ForeColor = System.Drawing.Color.White;
            this.pbarTime.Location = new System.Drawing.Point(43, 109);
            this.pbarTime.Name = "pbarTime";
            this.pbarTime.ProgressColor = System.Drawing.Color.Lime;
            this.pbarTime.ProgressEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.pbarTime.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbarTime.ShadowDecoration.Parent = this.pbarTime;
            this.pbarTime.Size = new System.Drawing.Size(250, 250);
            this.pbarTime.TabIndex = 0;
            this.pbarTime.Value = 100;
            // 
            // pbPlayPause
            // 
            this.pbPlayPause.Image = global::Project4__TimerApp.Properties.Resources._001_play;
            this.pbPlayPause.Location = new System.Drawing.Point(92, 147);
            this.pbPlayPause.Name = "pbPlayPause";
            this.pbPlayPause.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPlayPause.ShadowDecoration.Parent = this.pbPlayPause;
            this.pbPlayPause.Size = new System.Drawing.Size(58, 57);
            this.pbPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayPause.TabIndex = 8;
            this.pbPlayPause.TabStop = false;
            this.pbPlayPause.Click += new System.EventHandler(this.pbPlayPause_Click);
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentTime.Location = new System.Drawing.Point(43, 90);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(150, 43);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "00:00:00";
            this.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udHours
            // 
            this.udHours.BackColor = System.Drawing.Color.Transparent;
            this.udHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.udHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.udHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.udHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.udHours.DisabledState.Parent = this.udHours;
            this.udHours.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.udHours.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.udHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.udHours.FocusedState.Parent = this.udHours;
            this.udHours.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.udHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.udHours.Location = new System.Drawing.Point(50, 54);
            this.udHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.udHours.Name = "udHours";
            this.udHours.ShadowDecoration.Parent = this.udHours;
            this.udHours.Size = new System.Drawing.Size(61, 34);
            this.udHours.TabIndex = 1;
            this.udHours.UpDownButtonFillColor = System.Drawing.Color.Orange;
            this.udHours.ValueChanged += new System.EventHandler(this.udHours_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hours";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udsecond
            // 
            this.udsecond.BackColor = System.Drawing.Color.Transparent;
            this.udsecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.udsecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.udsecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.udsecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.udsecond.DisabledState.Parent = this.udsecond;
            this.udsecond.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.udsecond.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.udsecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.udsecond.FocusedState.Parent = this.udsecond;
            this.udsecond.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.udsecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.udsecond.Location = new System.Drawing.Point(224, 54);
            this.udsecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udsecond.Name = "udsecond";
            this.udsecond.ShadowDecoration.Parent = this.udsecond;
            this.udsecond.Size = new System.Drawing.Size(61, 34);
            this.udsecond.TabIndex = 3;
            this.udsecond.UpDownButtonFillColor = System.Drawing.Color.Orange;
            this.udsecond.ValueChanged += new System.EventHandler(this.udHours_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seconds";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // udminutes
            // 
            this.udminutes.BackColor = System.Drawing.Color.Transparent;
            this.udminutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.udminutes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.udminutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.udminutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.udminutes.DisabledState.Parent = this.udminutes;
            this.udminutes.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.udminutes.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.udminutes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.udminutes.FocusedState.Parent = this.udminutes;
            this.udminutes.Font = new System.Drawing.Font("Cooper Black", 9F);
            this.udminutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.udminutes.Location = new System.Drawing.Point(137, 54);
            this.udminutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udminutes.Name = "udminutes";
            this.udminutes.ShadowDecoration.Parent = this.udminutes;
            this.udminutes.Size = new System.Drawing.Size(61, 34);
            this.udminutes.TabIndex = 5;
            this.udminutes.UpDownButtonFillColor = System.Drawing.Color.Orange;
            this.udminutes.ValueChanged += new System.EventHandler(this.udHours_ValueChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = " :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = " :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(354, 373);
            this.Controls.Add(this.pbarTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.udminutes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.udsecond);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.udHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountDown";
            this.Text = "CountDown";
            this.pbarTime.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udsecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udminutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar pbarTime;
        private Guna.UI2.WinForms.Guna2NumericUpDown udHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2NumericUpDown udsecond;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown udminutes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCurrentTime;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbPlayPause;
        private System.Windows.Forms.Timer timer1;
    }
}