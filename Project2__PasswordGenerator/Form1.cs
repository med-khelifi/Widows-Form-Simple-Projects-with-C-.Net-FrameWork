using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool isValidInputs()
        {
            return (chkUpperCase.Checked || chkLowerCase.Checked || chkNumbers.Checked || chkSpecialCharacter.Checked);
        }
        private string GeneratePassword(bool UpperCase, bool LowerCase, bool Numbers, bool SpecialCharacter)
        {
            string Password = "";
            string PasswordItems = "";

            if (UpperCase)
                PasswordItems += chkUpperCase.Tag.ToString();

            if (LowerCase)
                PasswordItems += chkLowerCase.Tag.ToString();

            if (Numbers)
                PasswordItems += chkNumbers.Tag.ToString();

            if (SpecialCharacter)
                PasswordItems += chkSpecialCharacter.Tag.ToString();

            Random rd = new Random();
            

            for(byte i = 0;i < LengthTrackBar.Value; i++)
            {
                Password += PasswordItems[rd.Next(0, PasswordItems.Length - 1)];
            }

            return Password;
        }

        public Form1()
        {
            InitializeComponent();
            LengthTrackBar.Value = 10;
        }

        private void LengthTrackBar_Scroll(object sender, EventArgs e)
        {
            lblLength.Text = "Length : " + LengthTrackBar.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (isValidInputs())
            {
                txtPassword.Text = GeneratePassword(chkUpperCase.Checked, chkLowerCase.Checked, chkNumbers.Checked, chkSpecialCharacter.Checked);
            }
                
            else
            {
                errorProvider1.SetError(button1, "Invalid Input : No Box is Checked");
            }
        }
    }
}
