using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7__Who_Wants_To_Be_Millionaire
{
    public partial class Form1 : Form
    {
        List<clsQuestion> GameQuestions;
        List<Guna2Button> ProgressButtons ;
        clsQuestion CurrentQuestion;
        byte QuestionIndex = 0;
        byte TimeRest;
        string AmountWinned, PlayerName;

        bool GoToNextQuestion = false;
        bool ExitGame = false;
        private void SetQuestion(byte QuestionIndex)
        {
            CurrentQuestion = GameQuestions[QuestionIndex];
            btnQuestionText.Text = CurrentQuestion.Question;
            btnAns1.Text = "A : " + CurrentQuestion.Ans1;
            btnAns2.Text = "B : " + CurrentQuestion.Ans2;
            btnAns3.Text = "C : " + CurrentQuestion.Ans3;
            btnAns4.Text = "D : " + CurrentQuestion.Ans4;
        }
            
        private String GetWinnedAmount()
        {
            if(QuestionIndex == 0)
            {
                return " 0 $";
            }
            else
            {
                return ProgressButtons[QuestionIndex - 1].Text.ToString() + " $";
            }
        }

        private void ResetTime()
        {
            TimeRest = 60; // Inatialte Timer
            btnTimeRemaine.Text = "60";
        }

        private void ResetButtonVisibilityWhen50_50Used()
        {
            if (btnAns1.Visible == false)
            {
                btnAns1.Visible = true;
                btnAns4.Visible = true;
            }
            if (btnAns3.Visible == false)
            {
                btnAns3.Visible = true;
                btnAns2.Visible = true;
            }
        }

        private void ResetAllButtons()
        {
            ResetButtonVisibilityWhen50_50Used();

            // Change Backcolor To All Money Buttons
            foreach (Guna2Button btn in ProgressButtons)
            {
                btn.FillColor = System.Drawing.Color.Transparent;
            }

            btnCallFriend.Enabled = true;
            btnAskAudience.Enabled = true;
            btn50_50.Enabled = true;
        }
        public void InitilizeForm()
        {
            lblPlayerName.Text = PlayerName;
            QuestionIndex = 0;
            GameQuestions = clsQuestion.GetQuestions(); // Load 14 Question
            // Store Money Buttons
            ProgressButtons = new List<Guna2Button>{btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9,btn10,btn11,btn12,btn13,btn14};

            ResetAllButtons();

            SetQuestion(QuestionIndex);
            ProgressButtons[QuestionIndex].FillColor = Color.Orange;
                

            ResetTime();

            ExitGame = false;
            GameTimer.Start();
        }
        public Form1(string PlayerName)
        {
            this.PlayerName = PlayerName;
            InitializeComponent();
            InitilizeForm();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            TimeRest--;
            btnTimeRemaine.Text = TimeRest.ToString();
            

          
            if (GoToNextQuestion)
            {
                QuestionIndex++;
                if(QuestionIndex <= 13)
                {
                

                    ProgressButtons[QuestionIndex].FillColor = Color.Orange;
                    SetQuestion(QuestionIndex);
                    ResetTime();

                    if (!btn50_50.Enabled)
                    {
                        ResetButtonVisibilityWhen50_50Used();
                    }
                }
                else
                {
                    ExitGame = true;
                }

                GoToNextQuestion = false;
            }



            if (TimeRest == 0 || ExitGame )
            {
                EndScreen frm = new EndScreen(GetWinnedAmount(),PlayerName);
                //await Task.

                 GameTimer.Stop();
                
                frm.ShowDialog();

                /*
                while (frm.DialogResult == null)
                {
                    await Task.Delay(700);
                }
                */


                if(frm.DialogResult == DialogResult.Retry)
                {
                    InitilizeForm();
                }
                if (frm.DialogResult == DialogResult.Abort)
                {
                  
                    this.Close();
                }
            }

        }

        private async void AnswersButtons_Cliked(object sender, EventArgs e)
        {
            bool Ans = true;
            
            if (((Guna2Button)sender).Tag.ToString()[0] == CurrentQuestion.CorrectAnswer)
            {
                ChangeButtonColorDependsTheAnswer((Guna2Button)sender, true);
                Ans = true;
            }
            else
            {
                ChangeButtonColorDependsTheAnswer((Guna2Button)sender, false);
                Ans = false;

            }
            
            await Task.Delay(2000);
            GoToNextQuestion = Ans;
            ExitGame = !Ans;
        }

        private async void ChangeButtonColorDependsTheAnswer(Guna2Button Btn,bool CorrectAnswear)
        {
            
            Color ChangeTo;
            if (CorrectAnswear)
            {
                ChangeTo = Color.Green;
            }
            else
            {
                ChangeTo = Color.Red;
            }

            for(byte x = 0; x < 6; x++)
            {
                await Task.Delay(150);
                Btn.FillColor = ChangeTo;
                await Task.Delay(150);
                Btn.FillColor = Color.DarkBlue;
                
            }

        }

        private void btn50_50_Click(object sender, EventArgs e)
        {
            btn50_50.Enabled = false;
            if(CurrentQuestion.CorrectAnswer == btnAns1.Tag.ToString()[0] || 
                CurrentQuestion.CorrectAnswer == btnAns4.Tag.ToString()[0])

            {
                btnAns3.Visible = false;
                btnAns2.Visible = false;
            }
            else
            {
                btnAns1.Visible = false;
                btnAns4.Visible = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitGame = true;
        }

        private void btnAskAudience_Click(object sender, EventArgs e)
        {
            btnAskAudience.Enabled = false;
            AskAudience frm = new AskAudience(CurrentQuestion.CorrectAnswer,!btn50_50.Enabled);
            frm.ShowDialog();
        }

        private void btnCallFriend_Click(object sender, EventArgs e)
        {
            btnCallFriend.Enabled = false;
            CallFriend frm = new CallFriend(CurrentQuestion.CorrectAnswer);
            frm.ShowDialog();

        }

    }
}
