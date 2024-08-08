namespace Project9__BankManagementSystem
{
    partial class frmManageCurrencyScreen
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
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeposit = new Guna.UI2.WinForms.Guna2Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.lblAccess = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Project9__BankManagementSystem.Properties.Resources.arrow;
            this.guna2PictureBox2.Location = new System.Drawing.Point(31, 12);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(50, 50);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 2;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.Click += new System.EventHandler(this.guna2PictureBox2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::Project9__BankManagementSystem.Properties.Resources.convert1;
            this.guna2PictureBox1.Location = new System.Drawing.Point(31, 93);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(128, 120);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnTransfer
            // 
            this.btnTransfer.CheckedState.Parent = this.btnTransfer;
            this.btnTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransfer.CustomImages.Parent = this.btnTransfer;
            this.btnTransfer.FillColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.HoverState.Parent = this.btnTransfer;
            this.btnTransfer.Location = new System.Drawing.Point(31, 351);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.ShadowDecoration.Parent = this.btnTransfer;
            this.btnTransfer.Size = new System.Drawing.Size(163, 54);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Exchange Currecy";
            this.btnTransfer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.CheckedState.Parent = this.btnWithdraw;
            this.btnWithdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithdraw.CustomImages.Parent = this.btnWithdraw;
            this.btnWithdraw.FillColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.HoverState.Parent = this.btnWithdraw;
            this.btnWithdraw.Location = new System.Drawing.Point(31, 293);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.ShadowDecoration.Parent = this.btnWithdraw;
            this.btnWithdraw.Size = new System.Drawing.Size(128, 54);
            this.btnWithdraw.TabIndex = 0;
            this.btnWithdraw.Text = "Update Rate";
            this.btnWithdraw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.CheckedState.Parent = this.btnDeposit;
            this.btnDeposit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeposit.CustomImages.Parent = this.btnDeposit;
            this.btnDeposit.FillColor = System.Drawing.Color.Transparent;
            this.btnDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.ForeColor = System.Drawing.Color.White;
            this.btnDeposit.HoverState.Parent = this.btnDeposit;
            this.btnDeposit.Location = new System.Drawing.Point(31, 235);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.ShadowDecoration.Parent = this.btnDeposit;
            this.btnDeposit.Size = new System.Drawing.Size(128, 54);
            this.btnDeposit.TabIndex = 0;
            this.btnDeposit.Text = "Currency List";
            this.btnDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.lblAccess);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(197, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(640, 519);
            this.mainPanel.TabIndex = 8;
            // 
            // lblAccess
            // 
            this.lblAccess.AutoSize = true;
            this.lblAccess.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccess.ForeColor = System.Drawing.Color.Red;
            this.lblAccess.Location = new System.Drawing.Point(148, 215);
            this.lblAccess.Name = "lblAccess";
            this.lblAccess.Size = new System.Drawing.Size(348, 30);
            this.lblAccess.TabIndex = 4;
            this.lblAccess.Text = "You Don\'t Permissions To Access";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.guna2PictureBox2);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Controls.Add(this.btnTransfer);
            this.panel1.Controls.Add(this.btnWithdraw);
            this.panel1.Controls.Add(this.btnDeposit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 519);
            this.panel1.TabIndex = 7;
            // 
            // frmManageCurrencyScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(837, 519);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageCurrencyScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageCurrencyScreen";
            this.Load += new System.EventHandler(this.frmManageCurrencyScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private Guna.UI2.WinForms.Guna2Button btnDeposit;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label lblAccess;
        private System.Windows.Forms.Panel panel1;
    }
}