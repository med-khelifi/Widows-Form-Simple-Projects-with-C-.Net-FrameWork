namespace Project9__BankManagementSystem
{
    partial class frmDeleteClientScreen
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
            this.txtSearchClient = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDeleteClient = new Guna.UI2.WinForms.Guna2Button();
            this.LoginHistory = new System.Windows.Forms.Label();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPinCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccNumber = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.txtSearchClient.Location = new System.Drawing.Point(89, 57);
            this.txtSearchClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.PasswordChar = '\0';
            this.txtSearchClient.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchClient.PlaceholderText = "Account Number";
            this.txtSearchClient.SelectedText = "";
            this.txtSearchClient.ShadowDecoration.Parent = this.txtSearchClient;
            this.txtSearchClient.Size = new System.Drawing.Size(516, 46);
            this.txtSearchClient.TabIndex = 37;
            this.txtSearchClient.Tag = "TXT";
            this.txtSearchClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchClient.TextChanged += new System.EventHandler(this.txtSearchClient_TextChanged);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteClient.BorderColor = System.Drawing.Color.White;
            this.btnDeleteClient.BorderRadius = 15;
            this.btnDeleteClient.BorderThickness = 3;
            this.btnDeleteClient.CheckedState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.CustomImages.Parent = this.btnDeleteClient;
            this.btnDeleteClient.FillColor = System.Drawing.Color.Transparent;
            this.btnDeleteClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClient.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClient.HoverState.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Location = new System.Drawing.Point(481, 396);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.ShadowDecoration.Parent = this.btnDeleteClient;
            this.btnDeleteClient.Size = new System.Drawing.Size(145, 46);
            this.btnDeleteClient.TabIndex = 35;
            this.btnDeleteClient.Text = "Delete Client";
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // LoginHistory
            // 
            this.LoginHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginHistory.AutoSize = true;
            this.LoginHistory.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHistory.ForeColor = System.Drawing.Color.White;
            this.LoginHistory.Location = new System.Drawing.Point(251, 13);
            this.LoginHistory.Name = "LoginHistory";
            this.LoginHistory.Size = new System.Drawing.Size(163, 30);
            this.LoginHistory.TabIndex = 34;
            this.LoginHistory.Tag = "";
            this.LoginHistory.Text = "Delete Client : ";
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
            this.txtBalance.Location = new System.Drawing.Point(89, 337);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBalance.PlaceholderText = "No Permission Yet";
            this.txtBalance.SelectedText = "";
            this.txtBalance.ShadowDecoration.Parent = this.txtBalance;
            this.txtBalance.Size = new System.Drawing.Size(288, 46);
            this.txtBalance.TabIndex = 27;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.White;
            this.txtPhoneNumber.BorderRadius = 20;
            this.txtPhoneNumber.BorderThickness = 3;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.FillColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.FocusedState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtPhoneNumber.HoverState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtPhoneNumber.Location = new System.Drawing.Point(89, 281);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.PlaceholderText = "Phone Number";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.ShadowDecoration.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Size = new System.Drawing.Size(379, 46);
            this.txtPhoneNumber.TabIndex = 28;
            this.txtPhoneNumber.Tag = "TXT";
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtLastName.Location = new System.Drawing.Point(370, 169);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(235, 46);
            this.txtLastName.TabIndex = 29;
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
            this.txtFirstName.Location = new System.Drawing.Point(89, 169);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(239, 46);
            this.txtFirstName.TabIndex = 30;
            this.txtFirstName.Tag = "TXT";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPinCode
            // 
            this.txtPinCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPinCode.BackColor = System.Drawing.Color.Transparent;
            this.txtPinCode.BorderColor = System.Drawing.Color.White;
            this.txtPinCode.BorderRadius = 20;
            this.txtPinCode.BorderThickness = 3;
            this.txtPinCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPinCode.DefaultText = "";
            this.txtPinCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPinCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPinCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.DisabledState.Parent = this.txtPinCode;
            this.txtPinCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPinCode.Enabled = false;
            this.txtPinCode.FillColor = System.Drawing.Color.DimGray;
            this.txtPinCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPinCode.FocusedState.Parent = this.txtPinCode;
            this.txtPinCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.ForeColor = System.Drawing.Color.White;
            this.txtPinCode.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtPinCode.HoverState.Parent = this.txtPinCode;
            this.txtPinCode.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtPinCode.Location = new System.Drawing.Point(370, 113);
            this.txtPinCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '\0';
            this.txtPinCode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPinCode.PlaceholderText = "Password";
            this.txtPinCode.SelectedText = "";
            this.txtPinCode.ShadowDecoration.Parent = this.txtPinCode;
            this.txtPinCode.Size = new System.Drawing.Size(235, 46);
            this.txtPinCode.TabIndex = 31;
            this.txtPinCode.Tag = "TXT";
            this.txtPinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.White;
            this.txtEmail.BorderRadius = 20;
            this.txtEmail.BorderThickness = 3;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.Parent = this.txtEmail;
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.Enabled = false;
            this.txtEmail.FillColor = System.Drawing.Color.DimGray;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtEmail.Location = new System.Drawing.Point(89, 225);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "E-mail";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(379, 46);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.Tag = "TXT";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtAccNumber.Location = new System.Drawing.Point(89, 113);
            this.txtAccNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.PasswordChar = '\0';
            this.txtAccNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAccNumber.PlaceholderText = "Account Number";
            this.txtAccNumber.SelectedText = "";
            this.txtAccNumber.ShadowDecoration.Parent = this.txtAccNumber;
            this.txtAccNumber.Size = new System.Drawing.Size(239, 46);
            this.txtAccNumber.TabIndex = 33;
            this.txtAccNumber.Tag = "TXT";
            this.txtAccNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmDeleteClientScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(715, 465);
            this.Controls.Add(this.txtSearchClient);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.LoginHistory);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAccNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeleteClientScreen";
            this.Text = "frmDeleteClientScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchClient;
        private Guna.UI2.WinForms.Guna2Button btnDeleteClient;
        private System.Windows.Forms.Label LoginHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtBalance;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtPinCode;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtAccNumber;
    }
}