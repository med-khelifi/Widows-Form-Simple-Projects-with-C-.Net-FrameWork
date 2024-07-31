namespace Project7__Who_Wants_To_Be_Millionaire
{
    partial class StartScreen
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
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.lblPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BorderColor = System.Drawing.Color.White;
            this.btnStart.BorderRadius = 15;
            this.btnStart.BorderThickness = 1;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.Blue;
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift SemiLight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(154, 348);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(219, 54);
            this.btnStart.TabIndex = 31;
            this.btnStart.Text = "Play";
            this.btnStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.BorderColor = System.Drawing.Color.DarkBlue;
            this.lblPlayerName.BorderRadius = 10;
            this.lblPlayerName.BorderThickness = 3;
            this.lblPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPlayerName.DefaultText = "";
            this.lblPlayerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lblPlayerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lblPlayerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblPlayerName.DisabledState.Parent = this.lblPlayerName;
            this.lblPlayerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lblPlayerName.FillColor = System.Drawing.Color.Snow;
            this.lblPlayerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPlayerName.FocusedState.Parent = this.lblPlayerName;
            this.lblPlayerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPlayerName.HoverState.Parent = this.lblPlayerName;
            this.lblPlayerName.Location = new System.Drawing.Point(154, 266);
            this.lblPlayerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.PasswordChar = '\0';
            this.lblPlayerName.PlaceholderText = "Enter Your Name ";
            this.lblPlayerName.SelectedText = "";
            this.lblPlayerName.ShadowDecoration.Parent = this.lblPlayerName;
            this.lblPlayerName.Size = new System.Drawing.Size(219, 60);
            this.lblPlayerName.TabIndex = 32;
            this.lblPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(46, 53);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(427, 40);
            this.guna2HtmlLabel1.TabIndex = 33;
            this.guna2HtmlLabel1.Text = "Who Wants To Be Millionaire";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(186, 450);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(173, 18);
            this.guna2HtmlLabel2.TabIndex = 34;
            this.guna2HtmlLabel2.Text = "created By : Mohamed Khelifi";
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project7__Who_Wants_To_Be_Millionaire.Properties.Resources.Who_Doesn_t_Want_to_Be_a_Millionaire_;
            this.ClientSize = new System.Drawing.Size(508, 480);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2TextBox lblPlayerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}