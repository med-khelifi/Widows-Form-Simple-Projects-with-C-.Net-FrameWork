namespace Project7__Who_Wants_To_Be_Millionaire
{
    partial class CallFriend
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
            this.pbPhone = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhone
            // 
            this.pbPhone.BackColor = System.Drawing.Color.Transparent;
            this.pbPhone.Image = global::Project7__Who_Wants_To_Be_Millionaire.Properties.Resources.icons8_ringer_volume_50__1_;
            this.pbPhone.Location = new System.Drawing.Point(97, 36);
            this.pbPhone.Name = "pbPhone";
            this.pbPhone.Size = new System.Drawing.Size(88, 78);
            this.pbPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhone.TabIndex = 20;
            this.pbPhone.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(19, 168);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(245, 52);
            this.lblResult.TabIndex = 21;
            this.lblResult.Text = "Caling...";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.White;
            this.btnClose.BorderRadius = 20;
            this.btnClose.BorderThickness = 2;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Aqua;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(100, 236);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(83, 57);
            this.btnClose.TabIndex = 22;
            this.btnClose.Tag = "3";
            this.btnClose.Text = "Close";
            this.btnClose.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CallFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project7__Who_Wants_To_Be_Millionaire.Properties.Resources.AskAudienceBackground;
            this.ClientSize = new System.Drawing.Size(284, 303);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.pbPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CallFriend";
            this.Text = "Call Friend";
            ((System.ComponentModel.ISupportInitialize)(this.pbPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPhone;
        private System.Windows.Forms.Label lblResult;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}