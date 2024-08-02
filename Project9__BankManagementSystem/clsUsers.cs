using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Project9__BankManagementSystem
{
   // private const string UsersFile = "Users.txt";
    internal class clsUsers : clsPerson
    {
        
        private string _AccountNumber { set; get; }
        private string _Password { set; get; }
        private int _Permessions { set; get; }
        private bool _MarkedForDelete { set; get; }

        private static string FilePath = "Users.txt";


        enum enPermession
        {
            
        };

        public clsUsers() : base() { }
        public clsUsers( string FirstName, string LastName,string Email, string Phone, string AccountNumber, string Password, int Permessions) : base(FirstName,LastName,Phone,Email)
        {
           
            _AccountNumber = AccountNumber;
            _Password = Password;
            _Permessions = Permessions;
        }
        public static clsUsers FindUser(string AccNumber ) {

            List<clsUsers> FileData = LoadUsersDataFromFile();
            if(FileData != null)
            {
                foreach (clsUsers User in FileData)
                {

                    if (User._AccountNumber == AccNumber) return User;
                }
            }
            

            return null;
        }

        public static clsUsers FindUser(string AccNumber,string PassWord)
        {

            List<clsUsers> FileData = LoadUsersDataFromFile();
            if(FileData != null)
            {
                foreach (clsUsers User in FileData)
                {

                    if (User._AccountNumber == AccNumber && User._Password == PassWord) return User;
                }
            }
            
            return null;
        }

        private static List<clsUsers> LoadUsersDataFromFile()
        {
            if (File.Exists(FilePath))
             {
                List<clsUsers> UsersList = new List<clsUsers>();

                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string Line;

                    while((Line = sr.ReadLine()) != null)
                    {
                        UsersList.Add(ConvertLineToUserRecord(Line));
                
                    }
                    return UsersList;
                }

            }
            else
            {
                MessageBox.Show("Uses File Not Found");
                return null;
            }

           
        }

        private static clsUsers ConvertLineToUserRecord(string Line)
        {
            string[] SplitedRecord = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

            return new clsUsers(SplitedRecord[0], SplitedRecord[1], SplitedRecord[2], SplitedRecord[3], SplitedRecord[4], SplitedRecord[5], Convert.ToInt32( SplitedRecord[6]));
        }
    
        public static List<clsUsers> GetUsersList()
        {
            return LoadUsersDataFromFile();
        }
    }
}
