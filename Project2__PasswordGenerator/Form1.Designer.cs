namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.chkUpperCase = new System.Windows.Forms.CheckBox();
            this.chkSpecialCharacter = new System.Windows.Forms.CheckBox();
            this.chkLowerCase = new System.Windows.Forms.CheckBox();
            this.chkNumbers = new System.Windows.Forms.CheckBox();
            this.LengthTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LengthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.button1.Location = new System.Drawing.Point(93, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkUpperCase
            // 
            this.chkUpperCase.AutoSize = true;
            this.chkUpperCase.FlatAppearance.BorderSize = 4;
            this.chkUpperCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUpperCase.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpperCase.Location = new System.Drawing.Point(93, 112);
            this.chkUpperCase.Name = "chkUpperCase";
            this.chkUpperCase.Size = new System.Drawing.Size(96, 27);
            this.chkUpperCase.TabIndex = 1;
            this.chkUpperCase.Tag = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
            this.chkUpperCase.Text = "UpperCase";
            this.chkUpperCase.UseVisualStyleBackColor = true;
            // 
            // chkSpecialCharacter
            // 
            this.chkSpecialCharacter.AutoSize = true;
            this.chkSpecialCharacter.FlatAppearance.BorderSize = 4;
            this.chkSpecialCharacter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSpecialCharacter.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSpecialCharacter.Location = new System.Drawing.Point(200, 155);
            this.chkSpecialCharacter.Name = "chkSpecialCharacter";
            this.chkSpecialCharacter.Size = new System.Drawing.Size(144, 27);
            this.chkSpecialCharacter.TabIndex = 4;
            this.chkSpecialCharacter.Tag = "!@#$%^&*()_+-={}[]:;\"\'<>,.?/\\|`~";
            this.chkSpecialCharacter.Text = "Special Character";
            this.chkSpecialCharacter.UseVisualStyleBackColor = true;
            // 
            // chkLowerCase
            // 
            this.chkLowerCase.AutoSize = true;
            this.chkLowerCase.FlatAppearance.BorderSize = 4;
            this.chkLowerCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkLowerCase.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLowerCase.Location = new System.Drawing.Point(200, 112);
            this.chkLowerCase.Name = "chkLowerCase";
            this.chkLowerCase.Size = new System.Drawing.Size(96, 27);
            this.chkLowerCase.TabIndex = 2;
            this.chkLowerCase.Tag = "abcdefghijklmnopqrstuvwxyz";
            this.chkLowerCase.Text = "LowerCase";
            this.chkLowerCase.UseVisualStyleBackColor = true;
            // 
            // chkNumbers
            // 
            this.chkNumbers.AutoSize = true;
            this.chkNumbers.FlatAppearance.BorderSize = 4;
            this.chkNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNumbers.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNumbers.Location = new System.Drawing.Point(93, 155);
            this.chkNumbers.Name = "chkNumbers";
            this.chkNumbers.Size = new System.Drawing.Size(86, 27);
            this.chkNumbers.TabIndex = 3;
            this.chkNumbers.Tag = "0123456789";
            this.chkNumbers.Text = "Numbers";
            this.chkNumbers.UseVisualStyleBackColor = true;
            // 
            // LengthTrackBar
            // 
            this.LengthTrackBar.Location = new System.Drawing.Point(63, 228);
            this.LengthTrackBar.Maximum = 20;
            this.LengthTrackBar.Minimum = 1;
            this.LengthTrackBar.Name = "LengthTrackBar";
            this.LengthTrackBar.Size = new System.Drawing.Size(275, 45);
            this.LengthTrackBar.TabIndex = 5;
            this.LengthTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.LengthTrackBar.Value = 1;
            this.LengthTrackBar.Scroll += new System.EventHandler(this.LengthTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password Generator";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(156, 202);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(89, 23);
            this.lblLength.TabIndex = 7;
            this.lblLength.Text = "Length : 10";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(93, 290);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(214, 20);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthTrackBar);
            this.Controls.Add(this.chkNumbers);
            this.Controls.Add(this.chkLowerCase);
            this.Controls.Add(this.chkSpecialCharacter);
            this.Controls.Add(this.chkUpperCase);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LengthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkUpperCase;
        private System.Windows.Forms.CheckBox chkSpecialCharacter;
        private System.Windows.Forms.CheckBox chkLowerCase;
        private System.Windows.Forms.CheckBox chkNumbers;
        private System.Windows.Forms.TrackBar LengthTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

