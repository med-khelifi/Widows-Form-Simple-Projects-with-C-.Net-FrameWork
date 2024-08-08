namespace Project9__BankManagementSystem
{
    partial class frmUpdateCurrencyRateScreen
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
            this.txtSearchCurrency = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdateRate = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.LoginHistory = new System.Windows.Forms.Label();
            this.txtCountry = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrencyCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtRate = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCurrencyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // txtSearchCurrency
            // 
            this.txtSearchCurrency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchCurrency.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchCurrency.BorderColor = System.Drawing.Color.White;
            this.txtSearchCurrency.BorderRadius = 20;
            this.txtSearchCurrency.BorderThickness = 3;
            this.txtSearchCurrency.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCurrency.DefaultText = "";
            this.txtSearchCurrency.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCurrency.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCurrency.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCurrency.DisabledState.Parent = this.txtSearchCurrency;
            this.txtSearchCurrency.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCurrency.FillColor = System.Drawing.Color.DimGray;
            this.txtSearchCurrency.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtSearchCurrency.FocusedState.Parent = this.txtSearchCurrency;
            this.txtSearchCurrency.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCurrency.ForeColor = System.Drawing.Color.White;
            this.txtSearchCurrency.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtSearchCurrency.HoverState.Parent = this.txtSearchCurrency;
            this.txtSearchCurrency.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtSearchCurrency.IconRight = global::Project9__BankManagementSystem.Properties.Resources.search;
            this.txtSearchCurrency.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtSearchCurrency.Location = new System.Drawing.Point(32, 73);
            this.txtSearchCurrency.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchCurrency.Name = "txtSearchCurrency";
            this.txtSearchCurrency.PasswordChar = '\0';
            this.txtSearchCurrency.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchCurrency.PlaceholderText = "Account Number";
            this.txtSearchCurrency.SelectedText = "";
            this.txtSearchCurrency.ShadowDecoration.Parent = this.txtSearchCurrency;
            this.txtSearchCurrency.Size = new System.Drawing.Size(516, 46);
            this.txtSearchCurrency.TabIndex = 37;
            this.txtSearchCurrency.Tag = "TXT";
            this.txtSearchCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchCurrency.TextChanged += new System.EventHandler(this.txtSearchCurrency_TextChanged);
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateRate.BorderColor = System.Drawing.Color.White;
            this.btnUpdateRate.BorderRadius = 15;
            this.btnUpdateRate.BorderThickness = 3;
            this.btnUpdateRate.CheckedState.Parent = this.btnUpdateRate;
            this.btnUpdateRate.CustomImages.Parent = this.btnUpdateRate;
            this.btnUpdateRate.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdateRate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRate.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRate.HoverState.Parent = this.btnUpdateRate;
            this.btnUpdateRate.Location = new System.Drawing.Point(403, 373);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.ShadowDecoration.Parent = this.btnUpdateRate;
            this.btnUpdateRate.Size = new System.Drawing.Size(145, 46);
            this.btnUpdateRate.TabIndex = 35;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
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
            this.btnClear.Location = new System.Drawing.Point(241, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.ShadowDecoration.Parent = this.btnClear;
            this.btnClear.Size = new System.Drawing.Size(145, 46);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // LoginHistory
            // 
            this.LoginHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginHistory.AutoSize = true;
            this.LoginHistory.Font = new System.Drawing.Font("Malgun Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginHistory.ForeColor = System.Drawing.Color.White;
            this.LoginHistory.Location = new System.Drawing.Point(160, 17);
            this.LoginHistory.Name = "LoginHistory";
            this.LoginHistory.Size = new System.Drawing.Size(251, 30);
            this.LoginHistory.TabIndex = 34;
            this.LoginHistory.Tag = "";
            this.LoginHistory.Text = "Update Currency Rate : ";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCountry.BackColor = System.Drawing.Color.Transparent;
            this.txtCountry.BorderColor = System.Drawing.Color.White;
            this.txtCountry.BorderRadius = 20;
            this.txtCountry.BorderThickness = 3;
            this.txtCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountry.DefaultText = "";
            this.txtCountry.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.DisabledState.Parent = this.txtCountry;
            this.txtCountry.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCountry.Enabled = false;
            this.txtCountry.FillColor = System.Drawing.Color.DimGray;
            this.txtCountry.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtCountry.FocusedState.Parent = this.txtCountry;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.ForeColor = System.Drawing.Color.White;
            this.txtCountry.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtCountry.HoverState.Parent = this.txtCountry;
            this.txtCountry.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtCountry.Location = new System.Drawing.Point(32, 204);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PasswordChar = '\0';
            this.txtCountry.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCountry.PlaceholderText = "First Name";
            this.txtCountry.SelectedText = "";
            this.txtCountry.ShadowDecoration.Parent = this.txtCountry;
            this.txtCountry.Size = new System.Drawing.Size(341, 46);
            this.txtCountry.TabIndex = 30;
            this.txtCountry.Tag = "TXT";
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrencyCode.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrencyCode.BorderColor = System.Drawing.Color.White;
            this.txtCurrencyCode.BorderRadius = 20;
            this.txtCurrencyCode.BorderThickness = 3;
            this.txtCurrencyCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrencyCode.DefaultText = "";
            this.txtCurrencyCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrencyCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrencyCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrencyCode.DisabledState.Parent = this.txtCurrencyCode;
            this.txtCurrencyCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrencyCode.Enabled = false;
            this.txtCurrencyCode.FillColor = System.Drawing.Color.DimGray;
            this.txtCurrencyCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtCurrencyCode.FocusedState.Parent = this.txtCurrencyCode;
            this.txtCurrencyCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyCode.ForeColor = System.Drawing.Color.White;
            this.txtCurrencyCode.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtCurrencyCode.HoverState.Parent = this.txtCurrencyCode;
            this.txtCurrencyCode.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtCurrencyCode.Location = new System.Drawing.Point(405, 148);
            this.txtCurrencyCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.PasswordChar = '\0';
            this.txtCurrencyCode.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCurrencyCode.PlaceholderText = "Password";
            this.txtCurrencyCode.SelectedText = "";
            this.txtCurrencyCode.ShadowDecoration.Parent = this.txtCurrencyCode;
            this.txtCurrencyCode.Size = new System.Drawing.Size(143, 46);
            this.txtCurrencyCode.TabIndex = 31;
            this.txtCurrencyCode.Tag = "TXT";
            this.txtCurrencyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRate.BackColor = System.Drawing.Color.Transparent;
            this.txtRate.BorderColor = System.Drawing.Color.White;
            this.txtRate.BorderRadius = 20;
            this.txtRate.BorderThickness = 3;
            this.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRate.DefaultText = "";
            this.txtRate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRate.DisabledState.Parent = this.txtRate;
            this.txtRate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRate.FillColor = System.Drawing.Color.DimGray;
            this.txtRate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtRate.FocusedState.Parent = this.txtRate;
            this.txtRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.Color.White;
            this.txtRate.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtRate.HoverState.Parent = this.txtRate;
            this.txtRate.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtRate.Location = new System.Drawing.Point(405, 204);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRate.Name = "txtRate";
            this.txtRate.PasswordChar = '\0';
            this.txtRate.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtRate.PlaceholderText = "E-mail";
            this.txtRate.SelectedText = "";
            this.txtRate.ShadowDecoration.Parent = this.txtRate;
            this.txtRate.Size = new System.Drawing.Size(143, 46);
            this.txtRate.TabIndex = 32;
            this.txtRate.Tag = "TXT";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtCurrencyName
            // 
            this.txtCurrencyName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCurrencyName.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrencyName.BorderColor = System.Drawing.Color.White;
            this.txtCurrencyName.BorderRadius = 20;
            this.txtCurrencyName.BorderThickness = 3;
            this.txtCurrencyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrencyName.DefaultText = "";
            this.txtCurrencyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCurrencyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCurrencyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrencyName.DisabledState.Parent = this.txtCurrencyName;
            this.txtCurrencyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCurrencyName.Enabled = false;
            this.txtCurrencyName.FillColor = System.Drawing.Color.DimGray;
            this.txtCurrencyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.txtCurrencyName.FocusedState.Parent = this.txtCurrencyName;
            this.txtCurrencyName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyName.ForeColor = System.Drawing.Color.White;
            this.txtCurrencyName.HoverState.BorderColor = System.Drawing.Color.White;
            this.txtCurrencyName.HoverState.Parent = this.txtCurrencyName;
            this.txtCurrencyName.IconLeftOffset = new System.Drawing.Point(20, 0);
            this.txtCurrencyName.Location = new System.Drawing.Point(32, 148);
            this.txtCurrencyName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrencyName.Name = "txtCurrencyName";
            this.txtCurrencyName.PasswordChar = '\0';
            this.txtCurrencyName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCurrencyName.PlaceholderText = "Account Number";
            this.txtCurrencyName.SelectedText = "";
            this.txtCurrencyName.ShadowDecoration.Parent = this.txtCurrencyName;
            this.txtCurrencyName.Size = new System.Drawing.Size(341, 46);
            this.txtCurrencyName.TabIndex = 33;
            this.txtCurrencyName.Tag = "TXT";
            this.txtCurrencyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmUpdateCurrencyRateScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(601, 446);
            this.Controls.Add(this.txtSearchCurrency);
            this.Controls.Add(this.btnUpdateRate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.LoginHistory);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtCurrencyCode);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtCurrencyName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateCurrencyRateScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateCurrencyRateScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtSearchCurrency;
        private Guna.UI2.WinForms.Guna2Button btnUpdateRate;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Label LoginHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtCountry;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrencyCode;
        private Guna.UI2.WinForms.Guna2TextBox txtRate;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrencyName;
    }
}