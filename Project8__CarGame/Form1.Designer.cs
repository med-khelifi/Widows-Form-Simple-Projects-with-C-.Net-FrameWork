namespace Project8__CarGame
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
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.txtPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlHistory = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBackToMainScreen = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblEmpty = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BorderColor = System.Drawing.Color.White;
            this.btnHistory.BorderRadius = 20;
            this.btnHistory.BorderThickness = 3;
            this.btnHistory.CheckedState.Parent = this.btnHistory;
            this.btnHistory.CustomImages.Parent = this.btnHistory;
            this.btnHistory.FillColor = System.Drawing.Color.Transparent;
            this.btnHistory.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnHistory.HoverState.Parent = this.btnHistory;
            this.btnHistory.Location = new System.Drawing.Point(150, 388);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(200, 50);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "History";
            this.btnHistory.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.BorderThickness = 3;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(150, 335);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(200, 50);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "Star Game";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderColor = System.Drawing.Color.White;
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.BorderThickness = 3;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button3.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Location = new System.Drawing.Point(150, 441);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(200, 50);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Exit";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.txtPlayerName.BorderColor = System.Drawing.Color.White;
            this.txtPlayerName.BorderRadius = 5;
            this.txtPlayerName.BorderThickness = 3;
            this.txtPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayerName.DefaultText = "";
            this.txtPlayerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlayerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlayerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlayerName.DisabledState.Parent = this.txtPlayerName;
            this.txtPlayerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlayerName.FillColor = System.Drawing.Color.Transparent;
            this.txtPlayerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerName.FocusedState.Parent = this.txtPlayerName;
            this.txtPlayerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.ForeColor = System.Drawing.Color.White;
            this.txtPlayerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerName.HoverState.Parent = this.txtPlayerName;
            this.txtPlayerName.Location = new System.Drawing.Point(150, 264);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.PasswordChar = '\0';
            this.txtPlayerName.PlaceholderText = "Enetr Your Name";
            this.txtPlayerName.SelectedText = "";
            this.txtPlayerName.ShadowDecoration.Parent = this.txtPlayerName;
            this.txtPlayerName.Size = new System.Drawing.Size(200, 50);
            this.txtPlayerName.TabIndex = 3;
            this.txtPlayerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlHistory
            // 
            this.pnlHistory.BackColor = System.Drawing.Color.Transparent;
            this.pnlHistory.Controls.Add(this.listView1);
            this.pnlHistory.Controls.Add(this.btnBackToMainScreen);
            this.pnlHistory.Controls.Add(this.lblEmpty);
            this.pnlHistory.Controls.Add(this.guna2HtmlLabel1);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.ShadowDecoration.Parent = this.pnlHistory;
            this.pnlHistory.Size = new System.Drawing.Size(500, 500);
            this.pnlHistory.TabIndex = 4;
            // 
            // btnBackToMainScreen
            // 
            this.btnBackToMainScreen.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToMainScreen.BorderColor = System.Drawing.Color.White;
            this.btnBackToMainScreen.BorderRadius = 20;
            this.btnBackToMainScreen.BorderThickness = 1;
            this.btnBackToMainScreen.CheckedState.Parent = this.btnBackToMainScreen;
            this.btnBackToMainScreen.CustomImages.Parent = this.btnBackToMainScreen;
            this.btnBackToMainScreen.FillColor = System.Drawing.Color.Transparent;
            this.btnBackToMainScreen.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainScreen.ForeColor = System.Drawing.Color.White;
            this.btnBackToMainScreen.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBackToMainScreen.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnBackToMainScreen.HoverState.Parent = this.btnBackToMainScreen;
            this.btnBackToMainScreen.Location = new System.Drawing.Point(111, 443);
            this.btnBackToMainScreen.Name = "btnBackToMainScreen";
            this.btnBackToMainScreen.ShadowDecoration.Parent = this.btnBackToMainScreen;
            this.btnBackToMainScreen.Size = new System.Drawing.Size(262, 45);
            this.btnBackToMainScreen.TabIndex = 3;
            this.btnBackToMainScreen.Text = "Back To Main Scrren";
            this.btnBackToMainScreen.Click += new System.EventHandler(this.btnBackToMainScreen_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Arial Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(180, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(149, 54);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "History";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::Project8__CarGame.Properties.Resources.CarLogo_removebg_preview;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(150, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(200, 139);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // lblEmpty
            // 
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.White;
            this.lblEmpty.Location = new System.Drawing.Point(111, 198);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(270, 35);
            this.lblEmpty.TabIndex = 1;
            this.lblEmpty.Text = "No Game Regestred";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colScore});
            this.listView1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(12, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(476, 325);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 234;
            // 
            // colScore
            // 
            this.colScore.Text = "Score";
            this.colScore.Width = 243;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project8__CarGame.Properties.Resources.carBackGround;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlHistory.ResumeLayout(false);
            this.pnlHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox txtPlayerName;
        private Guna.UI2.WinForms.Guna2Panel pnlHistory;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnBackToMainScreen;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmpty;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colScore;
    }
}

