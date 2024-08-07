namespace Project9__BankManagementSystem
{
    partial class frmTransferScreen
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
            this.btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            this.LoginHistory = new System.Windows.Forms.Label();
            this.txtTransferAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBalanceSender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastNameSender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstNameSender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccNumberSender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearchSender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAccNumberReceiver = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFirstNameReceiver = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLastNameReceiver = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBalanceReceiver = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearchReceiver = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTransfer.BorderColor = System.Drawing.Color.White;
            this.btnTransfer.BorderRadius = 15;
            this.btnTransfer.BorderThickness = 3;
            this.btnTransfer.CheckedState.Parent = this.btnTransfer;
            this.btnTransfer.CustomImages.Parent = this.btnTransfer;
            this.btnTransfer.FillColor = System.Drawing.Color.Transparent;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.HoverState.Parent = this.btnTransfer;
            this.btnTransfer.Location = new System.Drawing.Point(276, 390);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.ShadowDecoration.Parent = this.btnTransfer;
            this.btnTransfer.Size = new System.Drawing.Size(219, 46);
            this.btnTransfer.TabIndex = 62;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // LoginHistory
            // 
            this.LoginHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginHistory.AutoSize = true;
            this.LoginHistory.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHistory.ForeColor = System.Drawing.Color.White;
            this.LoginHistory.Location = new System.Drawing.Point(338, 8);
            this.LoginHistory.Name = "LoginHistory";
            this.LoginHistory.Size = new System.Drawing.Size(104, 30);
            this.LoginHistory.TabIndex = 61;
            this.LoginHistory.Tag = "";
            this.LoginHistory.Text = "Tranfer : ";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTransferAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtTransferAmount.BorderColor = System.Drawing.Color.White;
            this.txtTransferAmount.BorderRadius = 20;
            this.txtTransferAmount.BorderThickness = 3;
            this.txtTransferAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTransferAmount.DefaultText = "";
            this.txtTransferAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTransferAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTransferAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferAmount.DisabledState.Parent = this.txtTransferAmount;
            this.txtTransferAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTransferAmount.FillColor = System.Drawing.Color.DimGray;
            this.txtTransferAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtTransferAmount.FocusedState.Parent = this.txtTransferAmount;
            this.txtTransferAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferAmount.ForeColor = System.Drawing.Color.White;
            this.txtTransferAmount.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtTransferAmount.HoverState.Parent = this.txtTransferAmount;
            this.txtTransferAmount.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtTransferAmount.Location = new System.Drawing.Point(238, 336);
            this.txtTransferAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.PasswordChar = '\0';
            this.txtTransferAmount.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTransferAmount.PlaceholderText = "Deposit Amount";
            this.txtTransferAmount.SelectedText = "";
            this.txtTransferAmount.ShadowDecoration.Parent = this.txtTransferAmount;
            this.txtTransferAmount.Size = new System.Drawing.Size(288, 46);
            this.txtTransferAmount.TabIndex = 56;
            this.txtTransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransferAmount.TextChanged += new System.EventHandler(this.txtTransferAmount_TextChanged);
            // 
            // txtBalanceSender
            // 
            this.txtBalanceSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBalanceSender.BackColor = System.Drawing.Color.Transparent;
            this.txtBalanceSender.BorderColor = System.Drawing.Color.White;
            this.txtBalanceSender.BorderRadius = 20;
            this.txtBalanceSender.BorderThickness = 3;
            this.txtBalanceSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalanceSender.DefaultText = "";
            this.txtBalanceSender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalanceSender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalanceSender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalanceSender.DisabledState.Parent = this.txtBalanceSender;
            this.txtBalanceSender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalanceSender.Enabled = false;
            this.txtBalanceSender.FillColor = System.Drawing.Color.DimGray;
            this.txtBalanceSender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtBalanceSender.FocusedState.Parent = this.txtBalanceSender;
            this.txtBalanceSender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceSender.ForeColor = System.Drawing.Color.White;
            this.txtBalanceSender.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtBalanceSender.HoverState.Parent = this.txtBalanceSender;
            this.txtBalanceSender.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtBalanceSender.Location = new System.Drawing.Point(79, 280);
            this.txtBalanceSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBalanceSender.Name = "txtBalanceSender";
            this.txtBalanceSender.PasswordChar = '\0';
            this.txtBalanceSender.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBalanceSender.PlaceholderText = "No Permission Yet";
            this.txtBalanceSender.SelectedText = "";
            this.txtBalanceSender.ShadowDecoration.Parent = this.txtBalanceSender;
            this.txtBalanceSender.Size = new System.Drawing.Size(254, 46);
            this.txtBalanceSender.TabIndex = 57;
            this.txtBalanceSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastNameSender
            // 
            this.txtLastNameSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastNameSender.BackColor = System.Drawing.Color.Transparent;
            this.txtLastNameSender.BorderColor = System.Drawing.Color.White;
            this.txtLastNameSender.BorderRadius = 20;
            this.txtLastNameSender.BorderThickness = 3;
            this.txtLastNameSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameSender.DefaultText = "";
            this.txtLastNameSender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastNameSender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastNameSender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastNameSender.DisabledState.Parent = this.txtLastNameSender;
            this.txtLastNameSender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastNameSender.Enabled = false;
            this.txtLastNameSender.FillColor = System.Drawing.Color.DimGray;
            this.txtLastNameSender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtLastNameSender.FocusedState.Parent = this.txtLastNameSender;
            this.txtLastNameSender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameSender.ForeColor = System.Drawing.Color.White;
            this.txtLastNameSender.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtLastNameSender.HoverState.Parent = this.txtLastNameSender;
            this.txtLastNameSender.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtLastNameSender.Location = new System.Drawing.Point(79, 224);
            this.txtLastNameSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastNameSender.Name = "txtLastNameSender";
            this.txtLastNameSender.PasswordChar = '\0';
            this.txtLastNameSender.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtLastNameSender.PlaceholderText = "Last Name";
            this.txtLastNameSender.SelectedText = "";
            this.txtLastNameSender.ShadowDecoration.Parent = this.txtLastNameSender;
            this.txtLastNameSender.Size = new System.Drawing.Size(254, 46);
            this.txtLastNameSender.TabIndex = 58;
            this.txtLastNameSender.Tag = "TXT";
            this.txtLastNameSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstNameSender
            // 
            this.txtFirstNameSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstNameSender.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstNameSender.BorderColor = System.Drawing.Color.White;
            this.txtFirstNameSender.BorderRadius = 20;
            this.txtFirstNameSender.BorderThickness = 3;
            this.txtFirstNameSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstNameSender.DefaultText = "";
            this.txtFirstNameSender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstNameSender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstNameSender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstNameSender.DisabledState.Parent = this.txtFirstNameSender;
            this.txtFirstNameSender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstNameSender.Enabled = false;
            this.txtFirstNameSender.FillColor = System.Drawing.Color.DimGray;
            this.txtFirstNameSender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtFirstNameSender.FocusedState.Parent = this.txtFirstNameSender;
            this.txtFirstNameSender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameSender.ForeColor = System.Drawing.Color.White;
            this.txtFirstNameSender.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtFirstNameSender.HoverState.Parent = this.txtFirstNameSender;
            this.txtFirstNameSender.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtFirstNameSender.Location = new System.Drawing.Point(79, 168);
            this.txtFirstNameSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstNameSender.Name = "txtFirstNameSender";
            this.txtFirstNameSender.PasswordChar = '\0';
            this.txtFirstNameSender.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtFirstNameSender.PlaceholderText = "First Name";
            this.txtFirstNameSender.SelectedText = "";
            this.txtFirstNameSender.ShadowDecoration.Parent = this.txtFirstNameSender;
            this.txtFirstNameSender.Size = new System.Drawing.Size(254, 46);
            this.txtFirstNameSender.TabIndex = 59;
            this.txtFirstNameSender.Tag = "TXT";
            this.txtFirstNameSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccNumberSender
            // 
            this.txtAccNumberSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccNumberSender.BackColor = System.Drawing.Color.Transparent;
            this.txtAccNumberSender.BorderColor = System.Drawing.Color.White;
            this.txtAccNumberSender.BorderRadius = 20;
            this.txtAccNumberSender.BorderThickness = 3;
            this.txtAccNumberSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNumberSender.DefaultText = "";
            this.txtAccNumberSender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccNumberSender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccNumberSender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNumberSender.DisabledState.Parent = this.txtAccNumberSender;
            this.txtAccNumberSender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNumberSender.Enabled = false;
            this.txtAccNumberSender.FillColor = System.Drawing.Color.DimGray;
            this.txtAccNumberSender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtAccNumberSender.FocusedState.Parent = this.txtAccNumberSender;
            this.txtAccNumberSender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumberSender.ForeColor = System.Drawing.Color.White;
            this.txtAccNumberSender.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtAccNumberSender.HoverState.Parent = this.txtAccNumberSender;
            this.txtAccNumberSender.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtAccNumberSender.Location = new System.Drawing.Point(79, 112);
            this.txtAccNumberSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNumberSender.Name = "txtAccNumberSender";
            this.txtAccNumberSender.PasswordChar = '\0';
            this.txtAccNumberSender.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAccNumberSender.PlaceholderText = "Account Number";
            this.txtAccNumberSender.SelectedText = "";
            this.txtAccNumberSender.ShadowDecoration.Parent = this.txtAccNumberSender;
            this.txtAccNumberSender.Size = new System.Drawing.Size(254, 46);
            this.txtAccNumberSender.TabIndex = 60;
            this.txtAccNumberSender.Tag = "TXT";
            this.txtAccNumberSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchSender
            // 
            this.txtSearchSender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchSender.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchSender.BorderColor = System.Drawing.Color.White;
            this.txtSearchSender.BorderRadius = 20;
            this.txtSearchSender.BorderThickness = 3;
            this.txtSearchSender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchSender.DefaultText = "";
            this.txtSearchSender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchSender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchSender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSender.DisabledState.Parent = this.txtSearchSender;
            this.txtSearchSender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchSender.FillColor = System.Drawing.Color.DimGray;
            this.txtSearchSender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSearchSender.FocusedState.Parent = this.txtSearchSender;
            this.txtSearchSender.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSender.ForeColor = System.Drawing.Color.White;
            this.txtSearchSender.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtSearchSender.HoverState.Parent = this.txtSearchSender;
            this.txtSearchSender.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearchSender.IconRight = global::Project9__BankManagementSystem.Properties.Resources.search;
            this.txtSearchSender.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtSearchSender.Location = new System.Drawing.Point(79, 56);
            this.txtSearchSender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchSender.Name = "txtSearchSender";
            this.txtSearchSender.PasswordChar = '\0';
            this.txtSearchSender.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchSender.PlaceholderText = "Account Number";
            this.txtSearchSender.SelectedText = "";
            this.txtSearchSender.ShadowDecoration.Parent = this.txtSearchSender;
            this.txtSearchSender.Size = new System.Drawing.Size(254, 46);
            this.txtSearchSender.TabIndex = 63;
            this.txtSearchSender.Tag = "TXT";
            this.txtSearchSender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchSender.TextChanged += new System.EventHandler(this.txtSearchSender_TextChanged);
            // 
            // txtAccNumberReceiver
            // 
            this.txtAccNumberReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccNumberReceiver.BackColor = System.Drawing.Color.Transparent;
            this.txtAccNumberReceiver.BorderColor = System.Drawing.Color.White;
            this.txtAccNumberReceiver.BorderRadius = 20;
            this.txtAccNumberReceiver.BorderThickness = 3;
            this.txtAccNumberReceiver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccNumberReceiver.DefaultText = "";
            this.txtAccNumberReceiver.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAccNumberReceiver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAccNumberReceiver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNumberReceiver.DisabledState.Parent = this.txtAccNumberReceiver;
            this.txtAccNumberReceiver.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAccNumberReceiver.Enabled = false;
            this.txtAccNumberReceiver.FillColor = System.Drawing.Color.DimGray;
            this.txtAccNumberReceiver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtAccNumberReceiver.FocusedState.Parent = this.txtAccNumberReceiver;
            this.txtAccNumberReceiver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNumberReceiver.ForeColor = System.Drawing.Color.White;
            this.txtAccNumberReceiver.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtAccNumberReceiver.HoverState.Parent = this.txtAccNumberReceiver;
            this.txtAccNumberReceiver.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtAccNumberReceiver.Location = new System.Drawing.Point(425, 112);
            this.txtAccNumberReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccNumberReceiver.Name = "txtAccNumberReceiver";
            this.txtAccNumberReceiver.PasswordChar = '\0';
            this.txtAccNumberReceiver.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAccNumberReceiver.PlaceholderText = "Account Number";
            this.txtAccNumberReceiver.SelectedText = "";
            this.txtAccNumberReceiver.ShadowDecoration.Parent = this.txtAccNumberReceiver;
            this.txtAccNumberReceiver.Size = new System.Drawing.Size(254, 46);
            this.txtAccNumberReceiver.TabIndex = 60;
            this.txtAccNumberReceiver.Tag = "TXT";
            this.txtAccNumberReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstNameReceiver
            // 
            this.txtFirstNameReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstNameReceiver.BackColor = System.Drawing.Color.Transparent;
            this.txtFirstNameReceiver.BorderColor = System.Drawing.Color.White;
            this.txtFirstNameReceiver.BorderRadius = 20;
            this.txtFirstNameReceiver.BorderThickness = 3;
            this.txtFirstNameReceiver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFirstNameReceiver.DefaultText = "";
            this.txtFirstNameReceiver.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFirstNameReceiver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFirstNameReceiver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstNameReceiver.DisabledState.Parent = this.txtFirstNameReceiver;
            this.txtFirstNameReceiver.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFirstNameReceiver.Enabled = false;
            this.txtFirstNameReceiver.FillColor = System.Drawing.Color.DimGray;
            this.txtFirstNameReceiver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtFirstNameReceiver.FocusedState.Parent = this.txtFirstNameReceiver;
            this.txtFirstNameReceiver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNameReceiver.ForeColor = System.Drawing.Color.White;
            this.txtFirstNameReceiver.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtFirstNameReceiver.HoverState.Parent = this.txtFirstNameReceiver;
            this.txtFirstNameReceiver.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtFirstNameReceiver.Location = new System.Drawing.Point(425, 168);
            this.txtFirstNameReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstNameReceiver.Name = "txtFirstNameReceiver";
            this.txtFirstNameReceiver.PasswordChar = '\0';
            this.txtFirstNameReceiver.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtFirstNameReceiver.PlaceholderText = "First Name";
            this.txtFirstNameReceiver.SelectedText = "";
            this.txtFirstNameReceiver.ShadowDecoration.Parent = this.txtFirstNameReceiver;
            this.txtFirstNameReceiver.Size = new System.Drawing.Size(254, 46);
            this.txtFirstNameReceiver.TabIndex = 59;
            this.txtFirstNameReceiver.Tag = "TXT";
            this.txtFirstNameReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLastNameReceiver
            // 
            this.txtLastNameReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastNameReceiver.BackColor = System.Drawing.Color.Transparent;
            this.txtLastNameReceiver.BorderColor = System.Drawing.Color.White;
            this.txtLastNameReceiver.BorderRadius = 20;
            this.txtLastNameReceiver.BorderThickness = 3;
            this.txtLastNameReceiver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLastNameReceiver.DefaultText = "";
            this.txtLastNameReceiver.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLastNameReceiver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLastNameReceiver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastNameReceiver.DisabledState.Parent = this.txtLastNameReceiver;
            this.txtLastNameReceiver.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLastNameReceiver.Enabled = false;
            this.txtLastNameReceiver.FillColor = System.Drawing.Color.DimGray;
            this.txtLastNameReceiver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtLastNameReceiver.FocusedState.Parent = this.txtLastNameReceiver;
            this.txtLastNameReceiver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastNameReceiver.ForeColor = System.Drawing.Color.White;
            this.txtLastNameReceiver.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtLastNameReceiver.HoverState.Parent = this.txtLastNameReceiver;
            this.txtLastNameReceiver.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtLastNameReceiver.Location = new System.Drawing.Point(425, 224);
            this.txtLastNameReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastNameReceiver.Name = "txtLastNameReceiver";
            this.txtLastNameReceiver.PasswordChar = '\0';
            this.txtLastNameReceiver.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtLastNameReceiver.PlaceholderText = "Last Name";
            this.txtLastNameReceiver.SelectedText = "";
            this.txtLastNameReceiver.ShadowDecoration.Parent = this.txtLastNameReceiver;
            this.txtLastNameReceiver.Size = new System.Drawing.Size(254, 46);
            this.txtLastNameReceiver.TabIndex = 58;
            this.txtLastNameReceiver.Tag = "TXT";
            this.txtLastNameReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBalanceReceiver
            // 
            this.txtBalanceReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBalanceReceiver.BackColor = System.Drawing.Color.Transparent;
            this.txtBalanceReceiver.BorderColor = System.Drawing.Color.White;
            this.txtBalanceReceiver.BorderRadius = 20;
            this.txtBalanceReceiver.BorderThickness = 3;
            this.txtBalanceReceiver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalanceReceiver.DefaultText = "";
            this.txtBalanceReceiver.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalanceReceiver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalanceReceiver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalanceReceiver.DisabledState.Parent = this.txtBalanceReceiver;
            this.txtBalanceReceiver.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalanceReceiver.Enabled = false;
            this.txtBalanceReceiver.FillColor = System.Drawing.Color.DimGray;
            this.txtBalanceReceiver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtBalanceReceiver.FocusedState.Parent = this.txtBalanceReceiver;
            this.txtBalanceReceiver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceReceiver.ForeColor = System.Drawing.Color.White;
            this.txtBalanceReceiver.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtBalanceReceiver.HoverState.Parent = this.txtBalanceReceiver;
            this.txtBalanceReceiver.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtBalanceReceiver.Location = new System.Drawing.Point(425, 280);
            this.txtBalanceReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBalanceReceiver.Name = "txtBalanceReceiver";
            this.txtBalanceReceiver.PasswordChar = '\0';
            this.txtBalanceReceiver.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtBalanceReceiver.PlaceholderText = "No Permission Yet";
            this.txtBalanceReceiver.SelectedText = "";
            this.txtBalanceReceiver.ShadowDecoration.Parent = this.txtBalanceReceiver;
            this.txtBalanceReceiver.Size = new System.Drawing.Size(254, 46);
            this.txtBalanceReceiver.TabIndex = 57;
            this.txtBalanceReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearchReceiver
            // 
            this.txtSearchReceiver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchReceiver.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchReceiver.BorderColor = System.Drawing.Color.White;
            this.txtSearchReceiver.BorderRadius = 20;
            this.txtSearchReceiver.BorderThickness = 3;
            this.txtSearchReceiver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchReceiver.DefaultText = "";
            this.txtSearchReceiver.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchReceiver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchReceiver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchReceiver.DisabledState.Parent = this.txtSearchReceiver;
            this.txtSearchReceiver.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchReceiver.FillColor = System.Drawing.Color.DimGray;
            this.txtSearchReceiver.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSearchReceiver.FocusedState.Parent = this.txtSearchReceiver;
            this.txtSearchReceiver.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchReceiver.ForeColor = System.Drawing.Color.White;
            this.txtSearchReceiver.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtSearchReceiver.HoverState.Parent = this.txtSearchReceiver;
            this.txtSearchReceiver.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearchReceiver.IconRight = global::Project9__BankManagementSystem.Properties.Resources.search;
            this.txtSearchReceiver.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtSearchReceiver.Location = new System.Drawing.Point(425, 56);
            this.txtSearchReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchReceiver.Name = "txtSearchReceiver";
            this.txtSearchReceiver.PasswordChar = '\0';
            this.txtSearchReceiver.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchReceiver.PlaceholderText = "Account Number";
            this.txtSearchReceiver.SelectedText = "";
            this.txtSearchReceiver.ShadowDecoration.Parent = this.txtSearchReceiver;
            this.txtSearchReceiver.Size = new System.Drawing.Size(254, 46);
            this.txtSearchReceiver.TabIndex = 63;
            this.txtSearchReceiver.Tag = "TXT";
            this.txtSearchReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchReceiver.TextChanged += new System.EventHandler(this.txtSearchReceiver_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransferScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(740, 462);
            this.Controls.Add(this.txtSearchReceiver);
            this.Controls.Add(this.txtSearchSender);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.LoginHistory);
            this.Controls.Add(this.txtBalanceReceiver);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.txtLastNameReceiver);
            this.Controls.Add(this.txtBalanceSender);
            this.Controls.Add(this.txtFirstNameReceiver);
            this.Controls.Add(this.txtLastNameSender);
            this.Controls.Add(this.txtAccNumberReceiver);
            this.Controls.Add(this.txtFirstNameSender);
            this.Controls.Add(this.txtAccNumberSender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransferScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransferScreen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchSender;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private System.Windows.Forms.Label LoginHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtTransferAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtBalanceSender;
        private Guna.UI2.WinForms.Guna2TextBox txtLastNameSender;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstNameSender;
        private Guna.UI2.WinForms.Guna2TextBox txtAccNumberSender;
        private Guna.UI2.WinForms.Guna2TextBox txtAccNumberReceiver;
        private Guna.UI2.WinForms.Guna2TextBox txtFirstNameReceiver;
        private Guna.UI2.WinForms.Guna2TextBox txtLastNameReceiver;
        private Guna.UI2.WinForms.Guna2TextBox txtBalanceReceiver;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchReceiver;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}