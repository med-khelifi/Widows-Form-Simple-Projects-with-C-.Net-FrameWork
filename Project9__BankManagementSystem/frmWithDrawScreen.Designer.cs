namespace Project9__BankManagementSystem
{
    partial class frmWithDrawScreen
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
            this.txtSearchClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnWithdraw = new Guna.UI2.WinForms.Guna2Button();
            this.LoginHistory = new System.Windows.Forms.Label();
            this.txtDeposiAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchClient.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchClient.BorderColor = System.Drawing.Color.White;
            this.txtSearchClient.BorderRadius = 20;
            this.txtSearchClient.BorderThickness = 3;
            this.txtSearchClient.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchClient.DefaultText = "";
            this.txtSearchClient.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchClient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchClient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClient.DisabledState.Parent = this.txtSearchClient;
            this.txtSearchClient.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchClient.FillColor = System.Drawing.Color.DimGray;
            this.txtSearchClient.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSearchClient.FocusedState.Parent = this.txtSearchClient;
            this.txtSearchClient.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClient.ForeColor = System.Drawing.Color.White;
            this.txtSearchClient.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtSearchClient.HoverState.Parent = this.txtSearchClient;
            this.txtSearchClient.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearchClient.IconRight = global::Project9__BankManagementSystem.Properties.Resources.search;
            this.txtSearchClient.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtSearchClient.Location = new System.Drawing.Point(97, 68);
            this.txtSearchClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.PasswordChar = '\0';
            this.txtSearchClient.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchClient.PlaceholderText = "Account Number";
            this.txtSearchClient.SelectedText = "";
            this.txtSearchClient.ShadowDecoration.Parent = this.txtSearchClient;
            this.txtSearchClient.Size = new System.Drawing.Size(516, 46);
            this.txtSearchClient.TabIndex = 55;
            this.txtSearchClient.Tag = "TXT";
            this.txtSearchClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnWithdraw.BorderColor = System.Drawing.Color.White;
            this.btnWithdraw.BorderRadius = 15;
            this.btnWithdraw.BorderThickness = 3;
            this.btnWithdraw.CheckedState.Parent = this.btnWithdraw;
            this.btnWithdraw.CustomImages.Parent = this.btnWithdraw;
            this.btnWithdraw.FillColor = System.Drawing.Color.Transparent;
            this.btnWithdraw.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.HoverState.Parent = this.btnWithdraw;
            this.btnWithdraw.Location = new System.Drawing.Point(177, 394);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.ShadowDecoration.Parent = this.btnWithdraw;
            this.btnWithdraw.Size = new System.Drawing.Size(219, 46);
            this.btnWithdraw.TabIndex = 54;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // LoginHistory
            // 
            this.LoginHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginHistory.AutoSize = true;
            this.LoginHistory.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHistory.ForeColor = System.Drawing.Color.White;
            this.LoginHistory.Location = new System.Drawing.Point(289, 19);
            this.LoginHistory.Name = "LoginHistory";
            this.LoginHistory.Size = new System.Drawing.Size(129, 30);
            this.LoginHistory.TabIndex = 53;
            this.LoginHistory.Tag = "";
            this.LoginHistory.Text = "Withdraw : ";
            // 
            // txtDeposiAmount
            // 
            this.txtDeposiAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDeposiAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtDeposiAmount.BorderColor = System.Drawing.Color.White;
            this.txtDeposiAmount.BorderRadius = 20;
            this.txtDeposiAmount.BorderThickness = 3;
            this.txtDeposiAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDeposiAmount.DefaultText = "";
            this.txtDeposiAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDeposiAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDeposiAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposiAmount.DisabledState.Parent = this.txtDeposiAmount;
            this.txtDeposiAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDeposiAmount.FillColor = System.Drawing.Color.DimGray;
            this.txtDeposiAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtDeposiAmount.FocusedState.Parent = this.txtDeposiAmount;
            this.txtDeposiAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposiAmount.ForeColor = System.Drawing.Color.White;
            this.txtDeposiAmount.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtDeposiAmount.HoverState.Parent = this.txtDeposiAmount;
            this.txtDeposiAmount.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtDeposiAmount.Location = new System.Drawing.Point(97, 306);
            this.txtDeposiAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeposiAmount.Name = "txtDeposiAmount";
            this.txtDeposiAmount.PasswordChar = '\0';
            this.txtDeposiAmount.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtDeposiAmount.PlaceholderText = "Deposit Amount";
            this.txtDeposiAmount.SelectedText = "";
            this.txtDeposiAmount.ShadowDecoration.Parent = this.txtDeposiAmount;
            this.txtDeposiAmount.Size = new System.Drawing.Size(288, 46);
            this.txtDeposiAmount.TabIndex = 48;
            this.txtDeposiAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeposiAmount.TextChanged += new System.EventHandler(this.txtDeposiAmount_TextChanged);
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBalance.BackColor = System.Drawing.Color.Transparent;
            this.txtBalance.BorderColor = System.Drawing.Color.White;
            this.txtBalance.BorderRadius = 20;
            this.txtBalance.BorderThickness = 3;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.DefaultText = "";
            this.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.DisabledState.Parent = this.txtBalance;
            this.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.Enabled = false;
            this.txtBalance.FillColor = System.Drawing.Color.DimGray;
            this.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtBalance.FocusedState.Parent = this.txtBalance;
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.White;
            this.txtBalance.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtBalance.HoverState.Parent = this.txtBalance;
            this.txtBalance.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtBalance.Location = new System.Drawing.Point(97, 250);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBalance.PlaceholderText = "No Permission Yet";
            this.txtBalance.SelectedText = "";
            this.txtBalance.ShadowDecoration.Parent = this.txtBalance;
            this.txtBalance.Size = new System.Drawing.Size(288, 46);
            this.txtBalance.TabIndex = 49;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.BackColor = System.Drawing.Color.Transparent;
            this.txtLastName.BorderColor = System.Drawing.Color.White;
            this.txtLastName.BorderRadius = 20;
            this.txtLastName.BorderThickness = 3;
            this.txtLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastName.DefaultText = "";
            this.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.DisabledState.Parent = this.txtLastName;
            this.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastName.Enabled = false;
            this.txtLastName.FillColor = System.Drawing.Color.DimGray;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedState.Parent = this.txtLastName;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtLastName.HoverState.Parent = this.txtLastName;
            this.txtLastName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtLastName.Location = new System.Drawing.Point(378, 180);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(235, 46);
            this.txtLastName.TabIndex = 50;
            this.txtLastName.Tag = "TXT";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstName.BorderColor = System.Drawing.Color.White;
            this.txtFirstName.BorderRadius = 20;
            this.txtFirstName.BorderThickness = 3;
            this.txtFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstName.DefaultText = "";
            this.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.DisabledState.Parent = this.txtFirstName;
            this.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstName.Enabled = false;
            this.txtFirstName.FillColor = System.Drawing.Color.DimGray;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedState.Parent = this.txtFirstName;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtFirstName.Location = new System.Drawing.Point(97, 180);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(239, 46);
            this.txtFirstName.TabIndex = 51;
            this.txtFirstName.Tag = "TXT";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtAccNumber.BorderColor = System.Drawing.Color.White;
            this.txtAccNumber.BorderRadius = 20;
            this.txtAccNumber.BorderThickness = 3;
            this.txtAccNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNumber.DefaultText = "";
            this.txtAccNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNumber.DisabledState.Parent = this.txtAccNumber;
            this.txtAccNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNumber.Enabled = false;
            this.txtAccNumber.FillColor = System.Drawing.Color.DimGray;
            this.txtAccNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtAccNumber.FocusedState.Parent = this.txtAccNumber;
            this.txtAccNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumber.ForeColor = System.Drawing.Color.White;
            this.txtAccNumber.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtAccNumber.HoverState.Parent = this.txtAccNumber;
            this.txtAccNumber.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtAccNumber.Location = new System.Drawing.Point(202, 124);
            this.txtAccNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.PasswordChar = '\0';
            this.txtAccNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAccNumber.PlaceholderText = "Account Number";
            this.txtAccNumber.SelectedText = "";
            this.txtAccNumber.ShadowDecoration.Parent = this.txtAccNumber;
            this.txtAccNumber.Size = new System.Drawing.Size(328, 46);
            this.txtAccNumber.TabIndex = 52;
            this.txtAccNumber.Tag = "TXT";
            this.txtAccNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmWithDrawScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(715, 465);
            this.Controls.Add(this.txtSearchClient);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.LoginHistory);
            this.Controls.Add(this.txtDeposiAmount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtAccNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWithDrawScreen";
            this.Text = "frmWithDrawScreen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchClient;
        private Guna.UI2.WinForms.Guna2Button btnWithdraw;
        private System.Windows.Forms.Label LoginHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtDeposiAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtBalance;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtAccNumber;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}