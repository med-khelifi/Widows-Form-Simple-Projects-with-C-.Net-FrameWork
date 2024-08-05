namespace Project9__BankManagementSystem
{
    partial class frmAddNewUserScreen
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
            this.txtAccNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginHistory = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPermissions = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSetPermissions = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddUser = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.txtAccNumber.FillColor = System.Drawing.Color.DimGray;
            this.txtAccNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtAccNumber.FocusedState.Parent = this.txtAccNumber;
            this.txtAccNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumber.ForeColor = System.Drawing.Color.White;
            this.txtAccNumber.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtAccNumber.HoverState.Parent = this.txtAccNumber;
            this.txtAccNumber.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtAccNumber.Location = new System.Drawing.Point(42, 68);
            this.txtAccNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.PasswordChar = '\0';
            this.txtAccNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAccNumber.PlaceholderText = "Account Number";
            this.txtAccNumber.SelectedText = "";
            this.txtAccNumber.ShadowDecoration.Parent = this.txtAccNumber;
            this.txtAccNumber.Size = new System.Drawing.Size(239, 46);
            this.txtAccNumber.TabIndex = 1;
            this.txtAccNumber.Tag = "TXT";
            this.txtAccNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAccNumber.TextChanged += new System.EventHandler(this.txtAccNumber_TextChanged);
            // 
            // LoginHistory
            // 
            this.LoginHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginHistory.AutoSize = true;
            this.LoginHistory.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHistory.ForeColor = System.Drawing.Color.White;
            this.LoginHistory.Location = new System.Drawing.Point(219, 9);
            this.LoginHistory.Name = "LoginHistory";
            this.LoginHistory.Size = new System.Drawing.Size(171, 30);
            this.LoginHistory.TabIndex = 4;
            this.LoginHistory.Tag = "";
            this.LoginHistory.Text = "Add New User :";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 20;
            this.txtPassword.BorderThickness = 3;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.DimGray;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtPassword.Location = new System.Drawing.Point(323, 68);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(235, 46);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Tag = "TXT";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
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
            this.txtFirstName.FillColor = System.Drawing.Color.DimGray;
            this.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtFirstName.FocusedState.Parent = this.txtFirstName;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.White;
            this.txtFirstName.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtFirstName.HoverState.Parent = this.txtFirstName;
            this.txtFirstName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtFirstName.Location = new System.Drawing.Point(42, 138);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.ShadowDecoration.Parent = this.txtFirstName;
            this.txtFirstName.Size = new System.Drawing.Size(239, 46);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Tag = "TXT";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
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
            this.txtEmail.FillColor = System.Drawing.Color.DimGray;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedState.Parent = this.txtEmail;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.Parent = this.txtEmail;
            this.txtEmail.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtEmail.Location = new System.Drawing.Point(42, 207);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "E-mail";
            this.txtEmail.SelectedText = "";
            this.txtEmail.ShadowDecoration.Parent = this.txtEmail;
            this.txtEmail.Size = new System.Drawing.Size(379, 46);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Tag = "TXT";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
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
            this.txtLastName.FillColor = System.Drawing.Color.DimGray;
            this.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtLastName.FocusedState.Parent = this.txtLastName;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.White;
            this.txtLastName.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtLastName.HoverState.Parent = this.txtLastName;
            this.txtLastName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtLastName.Location = new System.Drawing.Point(323, 138);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.SelectedText = "";
            this.txtLastName.ShadowDecoration.Parent = this.txtLastName;
            this.txtLastName.Size = new System.Drawing.Size(235, 46);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Tag = "TXT";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
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
            this.txtPhoneNumber.FillColor = System.Drawing.Color.DimGray;
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.FocusedState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtPhoneNumber.HoverState.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtPhoneNumber.Location = new System.Drawing.Point(42, 275);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPhoneNumber.PlaceholderText = "Phone Number";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.ShadowDecoration.Parent = this.txtPhoneNumber;
            this.txtPhoneNumber.Size = new System.Drawing.Size(379, 46);
            this.txtPhoneNumber.TabIndex = 1;
            this.txtPhoneNumber.Tag = "TXT";
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // txtPermissions
            // 
            this.txtPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPermissions.BackColor = System.Drawing.Color.Transparent;
            this.txtPermissions.BorderColor = System.Drawing.Color.White;
            this.txtPermissions.BorderRadius = 20;
            this.txtPermissions.BorderThickness = 3;
            this.txtPermissions.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPermissions.DefaultText = "";
            this.txtPermissions.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPermissions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPermissions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPermissions.DisabledState.Parent = this.txtPermissions;
            this.txtPermissions.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPermissions.Enabled = false;
            this.txtPermissions.FillColor = System.Drawing.Color.DimGray;
            this.txtPermissions.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtPermissions.FocusedState.Parent = this.txtPermissions;
            this.txtPermissions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPermissions.ForeColor = System.Drawing.Color.White;
            this.txtPermissions.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtPermissions.HoverState.Parent = this.txtPermissions;
            this.txtPermissions.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtPermissions.Location = new System.Drawing.Point(42, 342);
            this.txtPermissions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPermissions.Name = "txtPermissions";
            this.txtPermissions.PasswordChar = '\0';
            this.txtPermissions.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPermissions.PlaceholderText = "No Permission Yet";
            this.txtPermissions.SelectedText = "";
            this.txtPermissions.ShadowDecoration.Parent = this.txtPermissions;
            this.txtPermissions.Size = new System.Drawing.Size(229, 46);
            this.txtPermissions.TabIndex = 1;
            this.txtPermissions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPermissions.TextChanged += new System.EventHandler(this.txtPermissions_TextChanged);
            // 
            // btnSetPermissions
            // 
            this.btnSetPermissions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetPermissions.BorderColor = System.Drawing.Color.White;
            this.btnSetPermissions.BorderRadius = 15;
            this.btnSetPermissions.BorderThickness = 3;
            this.btnSetPermissions.CheckedState.Parent = this.btnSetPermissions;
            this.btnSetPermissions.CustomImages.Parent = this.btnSetPermissions;
            this.btnSetPermissions.FillColor = System.Drawing.Color.Transparent;
            this.btnSetPermissions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetPermissions.ForeColor = System.Drawing.Color.White;
            this.btnSetPermissions.HoverState.Parent = this.btnSetPermissions;
            this.btnSetPermissions.Location = new System.Drawing.Point(286, 342);
            this.btnSetPermissions.Name = "btnSetPermissions";
            this.btnSetPermissions.ShadowDecoration.Parent = this.btnSetPermissions;
            this.btnSetPermissions.Size = new System.Drawing.Size(303, 46);
            this.btnSetPermissions.TabIndex = 5;
            this.btnSetPermissions.Text = "Set Permissions";
            this.btnSetPermissions.Click += new System.EventHandler(this.btnSetPermissions_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClear.BorderColor = System.Drawing.Color.White;
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderThickness = 3;
            this.btnClear.CheckedState.Parent = this.btnClear;
            this.btnClear.CustomImages.Parent = this.btnClear;
            this.btnClear.FillColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.Parent = this.btnClear;
            this.btnClear.Location = new System.Drawing.Point(286, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(145, 46);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.BorderColor = System.Drawing.Color.White;
            this.btnAddUser.BorderRadius = 15;
            this.btnAddUser.BorderThickness = 3;
            this.btnAddUser.CheckedState.Parent = this.btnAddUser;
            this.btnAddUser.CustomImages.Parent = this.btnAddUser;
            this.btnAddUser.FillColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.HoverState.Parent = this.btnAddUser;
            this.btnAddUser.Location = new System.Drawing.Point(444, 415);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.ShadowDecoration.Parent = this.btnAddUser;
            this.btnAddUser.Size = new System.Drawing.Size(145, 46);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // frmAddNewUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(635, 473);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSetPermissions);
            this.Controls.Add(this.LoginHistory);
            this.Controls.Add(this.txtPermissions);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAccNumber);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNewUserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewUserScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtAccNumber;
        private System.Windows.Forms.Label LoginHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtLastName;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtPermissions;
        private Guna.UI2.WinForms.Guna2Button btnSetPermissions;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnAddUser;
    }
}