namespace Project9__BankManagementSystem
{
    partial class frmPermissions
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
            this.panalManageUsers = new System.Windows.Forms.Panel();
            this.chkUpdateUser = new System.Windows.Forms.CheckBox();
            this.chkAddNewUser = new System.Windows.Forms.CheckBox();
            this.chkDeleteUser = new System.Windows.Forms.CheckBox();
            this.chkShowUsersList = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsManageUsers = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelManageClients = new System.Windows.Forms.Panel();
            this.chkUpdateClient = new System.Windows.Forms.CheckBox();
            this.chkAddNewClients = new System.Windows.Forms.CheckBox();
            this.chkDeleteCLient = new System.Windows.Forms.CheckBox();
            this.chkShowClientsList = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tsManageClients = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelTransactions = new System.Windows.Forms.Panel();
            this.chkTransfer = new System.Windows.Forms.CheckBox();
            this.chkWithdraw = new System.Windows.Forms.CheckBox();
            this.chkTransferLogs = new System.Windows.Forms.CheckBox();
            this.chkDeposit = new System.Windows.Forms.CheckBox();
            this.label = new System.Windows.Forms.Label();
            this.tsTransActions = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panalCurrencyExchange = new System.Windows.Forms.Panel();
            this.chkExchange = new System.Windows.Forms.CheckBox();
            this.chkUpdateCurrencyRate = new System.Windows.Forms.CheckBox();
            this.chkShowCurrencyList = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tsCurrencyExchange = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.LoginHistory = new System.Windows.Forms.Label();
            this.tsAllPermissions = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.tsLogingHistory = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSETPermissions = new Guna.UI2.WinForms.Guna2Button();
            this.panalManageUsers.SuspendLayout();
            this.panelManageClients.SuspendLayout();
            this.panelTransactions.SuspendLayout();
            this.panalCurrencyExchange.SuspendLayout();
            this.SuspendLayout();
            // 
            // panalManageUsers
            // 
            this.panalManageUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panalManageUsers.Controls.Add(this.chkUpdateUser);
            this.panalManageUsers.Controls.Add(this.chkAddNewUser);
            this.panalManageUsers.Controls.Add(this.chkDeleteUser);
            this.panalManageUsers.Controls.Add(this.chkShowUsersList);
            this.panalManageUsers.Controls.Add(this.label1);
            this.panalManageUsers.Controls.Add(this.tsManageUsers);
            this.panalManageUsers.Location = new System.Drawing.Point(12, 104);
            this.panalManageUsers.Name = "panalManageUsers";
            this.panalManageUsers.Size = new System.Drawing.Size(163, 160);
            this.panalManageUsers.TabIndex = 1;
            // 
            // chkUpdateUser
            // 
            this.chkUpdateUser.AutoSize = true;
            this.chkUpdateUser.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateUser.ForeColor = System.Drawing.Color.White;
            this.chkUpdateUser.Location = new System.Drawing.Point(16, 99);
            this.chkUpdateUser.Name = "chkUpdateUser";
            this.chkUpdateUser.Size = new System.Drawing.Size(90, 18);
            this.chkUpdateUser.TabIndex = 2;
            this.chkUpdateUser.Text = "Update User";
            this.chkUpdateUser.UseVisualStyleBackColor = true;
            this.chkUpdateUser.CheckedChanged += new System.EventHandler(this.chkManageUsersChanged);
            // 
            // chkAddNewUser
            // 
            this.chkAddNewUser.AutoSize = true;
            this.chkAddNewUser.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddNewUser.ForeColor = System.Drawing.Color.White;
            this.chkAddNewUser.Location = new System.Drawing.Point(16, 75);
            this.chkAddNewUser.Name = "chkAddNewUser";
            this.chkAddNewUser.Size = new System.Drawing.Size(99, 18);
            this.chkAddNewUser.TabIndex = 2;
            this.chkAddNewUser.Text = "Add New User";
            this.chkAddNewUser.UseVisualStyleBackColor = true;
            this.chkAddNewUser.CheckedChanged += new System.EventHandler(this.chkManageUsersChanged);
            // 
            // chkDeleteUser
            // 
            this.chkDeleteUser.AutoSize = true;
            this.chkDeleteUser.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteUser.ForeColor = System.Drawing.Color.White;
            this.chkDeleteUser.Location = new System.Drawing.Point(16, 123);
            this.chkDeleteUser.Name = "chkDeleteUser";
            this.chkDeleteUser.Size = new System.Drawing.Size(85, 18);
            this.chkDeleteUser.TabIndex = 2;
            this.chkDeleteUser.Text = "Delete User";
            this.chkDeleteUser.UseVisualStyleBackColor = true;
            this.chkDeleteUser.CheckedChanged += new System.EventHandler(this.chkManageUsersChanged);
            // 
            // chkShowUsersList
            // 
            this.chkShowUsersList.AutoSize = true;
            this.chkShowUsersList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowUsersList.ForeColor = System.Drawing.Color.White;
            this.chkShowUsersList.Location = new System.Drawing.Point(16, 51);
            this.chkShowUsersList.Name = "chkShowUsersList";
            this.chkShowUsersList.Size = new System.Drawing.Size(106, 18);
            this.chkShowUsersList.TabIndex = 2;
            this.chkShowUsersList.Text = "Show Users List";
            this.chkShowUsersList.UseVisualStyleBackColor = true;
            this.chkShowUsersList.CheckedChanged += new System.EventHandler(this.chkManageUsersChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage Users";
            // 
            // tsManageUsers
            // 
            this.tsManageUsers.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsManageUsers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsManageUsers.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageUsers.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageUsers.CheckedState.Parent = this.tsManageUsers;
            this.tsManageUsers.Location = new System.Drawing.Point(106, 12);
            this.tsManageUsers.Name = "tsManageUsers";
            this.tsManageUsers.ShadowDecoration.Parent = this.tsManageUsers;
            this.tsManageUsers.Size = new System.Drawing.Size(43, 20);
            this.tsManageUsers.TabIndex = 0;
            this.tsManageUsers.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageUsers.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageUsers.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageUsers.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageUsers.UncheckedState.Parent = this.tsManageUsers;
            this.tsManageUsers.CheckedChanged += new System.EventHandler(this.tsManageUsers_CheckedChanged);
            // 
            // panelManageClients
            // 
            this.panelManageClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelManageClients.Controls.Add(this.chkUpdateClient);
            this.panelManageClients.Controls.Add(this.chkAddNewClients);
            this.panelManageClients.Controls.Add(this.chkDeleteCLient);
            this.panelManageClients.Controls.Add(this.chkShowClientsList);
            this.panelManageClients.Controls.Add(this.label2);
            this.panelManageClients.Controls.Add(this.tsManageClients);
            this.panelManageClients.Location = new System.Drawing.Point(212, 104);
            this.panelManageClients.Name = "panelManageClients";
            this.panelManageClients.Size = new System.Drawing.Size(163, 160);
            this.panelManageClients.TabIndex = 1;
            // 
            // chkUpdateClient
            // 
            this.chkUpdateClient.AutoSize = true;
            this.chkUpdateClient.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateClient.ForeColor = System.Drawing.Color.White;
            this.chkUpdateClient.Location = new System.Drawing.Point(16, 99);
            this.chkUpdateClient.Name = "chkUpdateClient";
            this.chkUpdateClient.Size = new System.Drawing.Size(97, 18);
            this.chkUpdateClient.TabIndex = 2;
            this.chkUpdateClient.Text = "Update Client";
            this.chkUpdateClient.UseVisualStyleBackColor = true;
            this.chkUpdateClient.CheckedChanged += new System.EventHandler(this.chkManageClientsChanged);
            // 
            // chkAddNewClients
            // 
            this.chkAddNewClients.AutoSize = true;
            this.chkAddNewClients.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddNewClients.ForeColor = System.Drawing.Color.White;
            this.chkAddNewClients.Location = new System.Drawing.Point(16, 75);
            this.chkAddNewClients.Name = "chkAddNewClients";
            this.chkAddNewClients.Size = new System.Drawing.Size(106, 18);
            this.chkAddNewClients.TabIndex = 2;
            this.chkAddNewClients.Text = "Add New Client";
            this.chkAddNewClients.UseVisualStyleBackColor = true;
            this.chkAddNewClients.CheckedChanged += new System.EventHandler(this.chkManageClientsChanged);
            // 
            // chkDeleteCLient
            // 
            this.chkDeleteCLient.AutoSize = true;
            this.chkDeleteCLient.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteCLient.ForeColor = System.Drawing.Color.White;
            this.chkDeleteCLient.Location = new System.Drawing.Point(16, 123);
            this.chkDeleteCLient.Name = "chkDeleteCLient";
            this.chkDeleteCLient.Size = new System.Drawing.Size(85, 18);
            this.chkDeleteCLient.TabIndex = 2;
            this.chkDeleteCLient.Text = "Delete User";
            this.chkDeleteCLient.UseVisualStyleBackColor = true;
            this.chkDeleteCLient.CheckedChanged += new System.EventHandler(this.chkManageClientsChanged);
            // 
            // chkShowClientsList
            // 
            this.chkShowClientsList.AutoSize = true;
            this.chkShowClientsList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowClientsList.ForeColor = System.Drawing.Color.White;
            this.chkShowClientsList.Location = new System.Drawing.Point(16, 51);
            this.chkShowClientsList.Name = "chkShowClientsList";
            this.chkShowClientsList.Size = new System.Drawing.Size(113, 18);
            this.chkShowClientsList.TabIndex = 2;
            this.chkShowClientsList.Text = "Show Clients List";
            this.chkShowClientsList.UseVisualStyleBackColor = true;
            this.chkShowClientsList.CheckedChanged += new System.EventHandler(this.chkManageClientsChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Clients";
            // 
            // tsManageClients
            // 
            this.tsManageClients.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsManageClients.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsManageClients.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageClients.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageClients.CheckedState.Parent = this.tsManageClients;
            this.tsManageClients.Location = new System.Drawing.Point(106, 12);
            this.tsManageClients.Name = "tsManageClients";
            this.tsManageClients.ShadowDecoration.Parent = this.tsManageClients;
            this.tsManageClients.Size = new System.Drawing.Size(43, 20);
            this.tsManageClients.TabIndex = 0;
            this.tsManageClients.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageClients.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsManageClients.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsManageClients.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsManageClients.UncheckedState.Parent = this.tsManageClients;
            this.tsManageClients.CheckedChanged += new System.EventHandler(this.tsManageClients_CheckedChanged);
            // 
            // panelTransactions
            // 
            this.panelTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTransactions.Controls.Add(this.chkTransfer);
            this.panelTransactions.Controls.Add(this.chkWithdraw);
            this.panelTransactions.Controls.Add(this.chkTransferLogs);
            this.panelTransactions.Controls.Add(this.chkDeposit);
            this.panelTransactions.Controls.Add(this.label);
            this.panelTransactions.Controls.Add(this.tsTransActions);
            this.panelTransactions.Location = new System.Drawing.Point(412, 104);
            this.panelTransactions.Name = "panelTransactions";
            this.panelTransactions.Size = new System.Drawing.Size(163, 160);
            this.panelTransactions.TabIndex = 1;
            // 
            // chkTransfer
            // 
            this.chkTransfer.AutoSize = true;
            this.chkTransfer.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransfer.ForeColor = System.Drawing.Color.White;
            this.chkTransfer.Location = new System.Drawing.Point(16, 99);
            this.chkTransfer.Name = "chkTransfer";
            this.chkTransfer.Size = new System.Drawing.Size(67, 18);
            this.chkTransfer.TabIndex = 2;
            this.chkTransfer.Text = "Transfer";
            this.chkTransfer.UseVisualStyleBackColor = true;
            this.chkTransfer.CheckedChanged += new System.EventHandler(this.chkTransactionsChanged);
            // 
            // chkWithdraw
            // 
            this.chkWithdraw.AutoSize = true;
            this.chkWithdraw.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWithdraw.ForeColor = System.Drawing.Color.White;
            this.chkWithdraw.Location = new System.Drawing.Point(16, 75);
            this.chkWithdraw.Name = "chkWithdraw";
            this.chkWithdraw.Size = new System.Drawing.Size(77, 18);
            this.chkWithdraw.TabIndex = 2;
            this.chkWithdraw.Text = "Withdraw";
            this.chkWithdraw.UseVisualStyleBackColor = true;
            this.chkWithdraw.CheckedChanged += new System.EventHandler(this.chkTransactionsChanged);
            // 
            // chkTransferLogs
            // 
            this.chkTransferLogs.AutoSize = true;
            this.chkTransferLogs.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTransferLogs.ForeColor = System.Drawing.Color.White;
            this.chkTransferLogs.Location = new System.Drawing.Point(16, 123);
            this.chkTransferLogs.Name = "chkTransferLogs";
            this.chkTransferLogs.Size = new System.Drawing.Size(94, 18);
            this.chkTransferLogs.TabIndex = 2;
            this.chkTransferLogs.Text = "Transfer Logs";
            this.chkTransferLogs.UseVisualStyleBackColor = true;
            this.chkTransferLogs.CheckedChanged += new System.EventHandler(this.chkTransactionsChanged);
            // 
            // chkDeposit
            // 
            this.chkDeposit.AutoSize = true;
            this.chkDeposit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeposit.ForeColor = System.Drawing.Color.White;
            this.chkDeposit.Location = new System.Drawing.Point(16, 51);
            this.chkDeposit.Name = "chkDeposit";
            this.chkDeposit.Size = new System.Drawing.Size(66, 18);
            this.chkDeposit.TabIndex = 2;
            this.chkDeposit.Text = "Deposit";
            this.chkDeposit.UseVisualStyleBackColor = true;
            this.chkDeposit.CheckedChanged += new System.EventHandler(this.chkTransactionsChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(3, 12);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(86, 17);
            this.label.TabIndex = 1;
            this.label.Text = "Transactions";
            // 
            // tsTransActions
            // 
            this.tsTransActions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTransActions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsTransActions.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsTransActions.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsTransActions.CheckedState.Parent = this.tsTransActions;
            this.tsTransActions.Location = new System.Drawing.Point(106, 12);
            this.tsTransActions.Name = "tsTransActions";
            this.tsTransActions.ShadowDecoration.Parent = this.tsTransActions;
            this.tsTransActions.Size = new System.Drawing.Size(43, 20);
            this.tsTransActions.TabIndex = 0;
            this.tsTransActions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsTransActions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsTransActions.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsTransActions.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsTransActions.UncheckedState.Parent = this.tsTransActions;
            this.tsTransActions.CheckedChanged += new System.EventHandler(this.tsTransActions_CheckedChanged);
            // 
            // panalCurrencyExchange
            // 
            this.panalCurrencyExchange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panalCurrencyExchange.Controls.Add(this.chkExchange);
            this.panalCurrencyExchange.Controls.Add(this.chkUpdateCurrencyRate);
            this.panalCurrencyExchange.Controls.Add(this.chkShowCurrencyList);
            this.panalCurrencyExchange.Controls.Add(this.label3);
            this.panalCurrencyExchange.Controls.Add(this.tsCurrencyExchange);
            this.panalCurrencyExchange.Location = new System.Drawing.Point(603, 104);
            this.panalCurrencyExchange.Name = "panalCurrencyExchange";
            this.panalCurrencyExchange.Size = new System.Drawing.Size(163, 160);
            this.panalCurrencyExchange.TabIndex = 1;
            // 
            // chkExchange
            // 
            this.chkExchange.AutoSize = true;
            this.chkExchange.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExchange.ForeColor = System.Drawing.Color.White;
            this.chkExchange.Location = new System.Drawing.Point(16, 99);
            this.chkExchange.Name = "chkExchange";
            this.chkExchange.Size = new System.Drawing.Size(75, 18);
            this.chkExchange.TabIndex = 2;
            this.chkExchange.Text = "Exchange";
            this.chkExchange.UseVisualStyleBackColor = true;
            // 
            // chkUpdateCurrencyRate
            // 
            this.chkUpdateCurrencyRate.AutoSize = true;
            this.chkUpdateCurrencyRate.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateCurrencyRate.ForeColor = System.Drawing.Color.White;
            this.chkUpdateCurrencyRate.Location = new System.Drawing.Point(16, 75);
            this.chkUpdateCurrencyRate.Name = "chkUpdateCurrencyRate";
            this.chkUpdateCurrencyRate.Size = new System.Drawing.Size(138, 18);
            this.chkUpdateCurrencyRate.TabIndex = 2;
            this.chkUpdateCurrencyRate.Text = "Update Currency Rate";
            this.chkUpdateCurrencyRate.UseVisualStyleBackColor = true;
            // 
            // chkShowCurrencyList
            // 
            this.chkShowCurrencyList.AutoSize = true;
            this.chkShowCurrencyList.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowCurrencyList.ForeColor = System.Drawing.Color.White;
            this.chkShowCurrencyList.Location = new System.Drawing.Point(16, 51);
            this.chkShowCurrencyList.Name = "chkShowCurrencyList";
            this.chkShowCurrencyList.Size = new System.Drawing.Size(123, 18);
            this.chkShowCurrencyList.TabIndex = 2;
            this.chkShowCurrencyList.Text = "Show Currency List";
            this.chkShowCurrencyList.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "C.Exchange";
            // 
            // tsCurrencyExchange
            // 
            this.tsCurrencyExchange.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsCurrencyExchange.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsCurrencyExchange.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsCurrencyExchange.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsCurrencyExchange.CheckedState.Parent = this.tsCurrencyExchange;
            this.tsCurrencyExchange.Location = new System.Drawing.Point(99, 12);
            this.tsCurrencyExchange.Name = "tsCurrencyExchange";
            this.tsCurrencyExchange.ShadowDecoration.Parent = this.tsCurrencyExchange;
            this.tsCurrencyExchange.Size = new System.Drawing.Size(43, 20);
            this.tsCurrencyExchange.TabIndex = 0;
            this.tsCurrencyExchange.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsCurrencyExchange.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsCurrencyExchange.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsCurrencyExchange.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsCurrencyExchange.UncheckedState.Parent = this.tsCurrencyExchange;
            this.tsCurrencyExchange.CheckedChanged += new System.EventHandler(this.tsCurrencyExchange_CheckedChanged);
            // 
            // LoginHistory
            // 
            this.LoginHistory.AutoSize = true;
            this.LoginHistory.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHistory.ForeColor = System.Drawing.Color.White;
            this.LoginHistory.Location = new System.Drawing.Point(220, 9);
            this.LoginHistory.Name = "LoginHistory";
            this.LoginHistory.Size = new System.Drawing.Size(290, 30);
            this.LoginHistory.TabIndex = 3;
            this.LoginHistory.Text = "Select Permissions To Set : ";
            // 
            // tsAllPermissions
            // 
            this.tsAllPermissions.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsAllPermissions.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsAllPermissions.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsAllPermissions.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsAllPermissions.CheckedState.Parent = this.tsAllPermissions;
            this.tsAllPermissions.Location = new System.Drawing.Point(157, 63);
            this.tsAllPermissions.Name = "tsAllPermissions";
            this.tsAllPermissions.ShadowDecoration.Parent = this.tsAllPermissions;
            this.tsAllPermissions.Size = new System.Drawing.Size(43, 20);
            this.tsAllPermissions.TabIndex = 0;
            this.tsAllPermissions.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsAllPermissions.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsAllPermissions.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsAllPermissions.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsAllPermissions.UncheckedState.Parent = this.tsAllPermissions;
            this.tsAllPermissions.CheckedChanged += new System.EventHandler(this.tsAllPermissions_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Give All Permissions";
            // 
            // tsLogingHistory
            // 
            this.tsLogingHistory.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsLogingHistory.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tsLogingHistory.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsLogingHistory.CheckedState.InnerColor = System.Drawing.Color.White;
            this.tsLogingHistory.CheckedState.Parent = this.tsLogingHistory;
            this.tsLogingHistory.Location = new System.Drawing.Point(723, 63);
            this.tsLogingHistory.Name = "tsLogingHistory";
            this.tsLogingHistory.ShadowDecoration.Parent = this.tsLogingHistory;
            this.tsLogingHistory.Size = new System.Drawing.Size(43, 20);
            this.tsLogingHistory.TabIndex = 0;
            this.tsLogingHistory.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsLogingHistory.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.tsLogingHistory.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.tsLogingHistory.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.tsLogingHistory.UncheckedState.Parent = this.tsLogingHistory;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(616, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Loging History";
            // 
            // btnSETPermissions
            // 
            this.btnSETPermissions.BorderColor = System.Drawing.Color.White;
            this.btnSETPermissions.BorderRadius = 15;
            this.btnSETPermissions.BorderThickness = 3;
            this.btnSETPermissions.CheckedState.Parent = this.btnSETPermissions;
            this.btnSETPermissions.CustomImages.Parent = this.btnSETPermissions;
            this.btnSETPermissions.FillColor = System.Drawing.Color.Transparent;
            this.btnSETPermissions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSETPermissions.ForeColor = System.Drawing.Color.White;
            this.btnSETPermissions.HoverState.Parent = this.btnSETPermissions;
            this.btnSETPermissions.Location = new System.Drawing.Point(240, 286);
            this.btnSETPermissions.Name = "btnSETPermissions";
            this.btnSETPermissions.ShadowDecoration.Parent = this.btnSETPermissions;
            this.btnSETPermissions.Size = new System.Drawing.Size(234, 60);
            this.btnSETPermissions.TabIndex = 4;
            this.btnSETPermissions.Text = "Set";
            this.btnSETPermissions.Click += new System.EventHandler(this.btnSETPermissions_Click);
            // 
            // frmPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(778, 372);
            this.Controls.Add(this.btnSETPermissions);
            this.Controls.Add(this.LoginHistory);
            this.Controls.Add(this.panelTransactions);
            this.Controls.Add(this.panelManageClients);
            this.Controls.Add(this.panalCurrencyExchange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tsLogingHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tsAllPermissions);
            this.Controls.Add(this.panalManageUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPermissions";
            this.panalManageUsers.ResumeLayout(false);
            this.panalManageUsers.PerformLayout();
            this.panelManageClients.ResumeLayout(false);
            this.panelManageClients.PerformLayout();
            this.panelTransactions.ResumeLayout(false);
            this.panelTransactions.PerformLayout();
            this.panalCurrencyExchange.ResumeLayout(false);
            this.panalCurrencyExchange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panalManageUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUpdateUser;
        private System.Windows.Forms.CheckBox chkAddNewUser;
        private System.Windows.Forms.CheckBox chkDeleteUser;
        private System.Windows.Forms.CheckBox chkShowUsersList;
        private System.Windows.Forms.Panel panelManageClients;
        private System.Windows.Forms.CheckBox chkUpdateClient;
        private System.Windows.Forms.CheckBox chkAddNewClients;
        private System.Windows.Forms.CheckBox chkDeleteCLient;
        private System.Windows.Forms.CheckBox chkShowClientsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTransactions;
        private System.Windows.Forms.CheckBox chkTransfer;
        private System.Windows.Forms.CheckBox chkWithdraw;
        private System.Windows.Forms.CheckBox chkTransferLogs;
        private System.Windows.Forms.CheckBox chkDeposit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panalCurrencyExchange;
        private System.Windows.Forms.CheckBox chkExchange;
        private System.Windows.Forms.CheckBox chkUpdateCurrencyRate;
        private System.Windows.Forms.CheckBox chkShowCurrencyList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LoginHistory;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsAllPermissions;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsLogingHistory;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnSETPermissions;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageUsers;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsManageClients;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsTransActions;
        private Guna.UI2.WinForms.Guna2ToggleSwitch tsCurrencyExchange;
    }
}