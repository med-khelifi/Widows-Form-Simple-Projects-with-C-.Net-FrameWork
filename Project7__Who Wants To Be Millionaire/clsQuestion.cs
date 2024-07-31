using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project7__Who_Wants_To_Be_Millionaire
{
    
    internal class clsQuestion
    {
        public string Question;
        public string Ans1;
        public string Ans2;
        public string Ans3;
        public string Ans4;
        public char CorrectAnswer;

        private static string EasyQuestionFilePath = @"C:\Users\hp\Desktop\Wal3a\Coding\ProgrammingAdvices\course_14 C# Level1\Projects\Project7__Who Wants To Be Millionaire\QuestionsFiles\easy_questions.txt";  //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QuestionsFiles", "easy_questions.txt");
        private static string MediumQuestionFilePath = @"C:\Users\hp\Desktop\Wal3a\Coding\ProgrammingAdvices\course_14 C# Level1\Projects\Project7__Who Wants To Be Millionaire\QuestionsFiles\medium_questions.txt";//Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QuestionsFiles", "medium_questions.txt") ;
        private static string HardQuestionFilePath = @"C:\Users\hp\Desktop\Wal3a\Coding\ProgrammingAdvices\course_14 C# Level1\Projects\Project7__Who Wants To Be Millionaire\QuestionsFiles\hard_questions.txt";  //Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "QuestionsFiles", "hard_questions.txt");

        public clsQuestion(string Question,string Ans1,string Ans2,string Ans3,string Ans4,char CorrectAnswer) { 
            this.Question = Question;
            this.Ans1 = Ans1;
            this.Ans2 = Ans2;
            this.Ans3 = Ans3;
            this.Ans4 = Ans4;
            this.CorrectAnswer = CorrectAnswer;
        }
        public clsQuestion() { }
        private static List<clsQuestion> GetAllQuestionsByLevel(string Level)
        {
            string filePath;

            if(Level.ToLower() == "easy")
                filePath = EasyQuestionFilePath;
            else if(Level.ToLower() =="medium")
                filePath = MediumQuestionFilePath;
            else 
                filePath = HardQuestionFilePath;

            List<clsQuestion> Ques = new List<clsQuestion>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Ques.Add(ConvertLineToQuestioRecord(line));
                }
            }

            return Ques;
        }

        public static List<clsQuestion> GetQuestions(byte Easy= 4 ,byte Medium = 5,byte Hard = 5) 
       {
            List<clsQuestion> EasyQues = GetAllQuestionsByLevel("easy");
            List<clsQuestion> MediumQues = GetAllQuestionsByLevel("medium");
            List<clsQuestion> HardQues = GetAllQuestionsByLevel("hard");

            Random rd = new Random();

            byte Rand = 0;
            
            List<clsQuestion> AllQues = new List<clsQuestion>(); 

            for(byte x = 0;x < Easy; x++)
            {
                Rand = (byte) rd.Next(0, EasyQues.Count);
                AllQues.Add(EasyQues[Rand]);
                EasyQues.RemoveAt(Rand);
                
            }


            for (byte x = 0; x < Medium; x++)
            {
                Rand = (byte)rd.Next(0,MediumQues.Count);
                AllQues.Add(MediumQues[Rand]);
                MediumQues.RemoveAt(Rand);
            }

            

            for (byte x = 0; x < Hard; x++)
            {
                Rand = (byte)rd.Next(0,HardQues.Count);
                AllQues.Add(HardQues[Rand]);
                HardQues.RemoveAt(Rand);
            }

            return AllQues;
       }
        
        private static clsQuestion ConvertLineToQuestioRecord(string Line) {

            string[] quesArray = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

            
            return new clsQuestion(quesArray[0], quesArray[1], quesArray[2], quesArray[3], quesArray[4], (char)quesArray[5][0]);
        }

    }
    
}
