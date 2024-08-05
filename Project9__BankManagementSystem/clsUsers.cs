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
        
        public string _AccountNumber { set; get; }
        public string _Password { set; get; }
        public int _Permessions { set; get; }
        public bool _MarkedForDelete { set; get; } = false;

        private static string FilePath = "Users.txt";

        //public bool ManageUsers = false, ManageClients = false, Transactions = false, LoggingHistory = false, CurrencyExchange = false;
        
        int Permissions = 0;
       
       public enum enPermession
        {
            eAll = -1,eShowUsersList = 1,eAddNewUser = 2,eUpdateUser = 4,eDeleteUser = 8,
                      eShowClientsList = 16,eAddNewClients = 32,eUpdateClient = 64,eDeleteClient = 128,
                      eShowCurrencyList = 256,eUpdateCurrecyRate = 512,eExchangeCurrency = 1024,
                      eDeposit = 2048,eWithdraw = 4096,eTransfer = 8192,eTransferHistory = 16384,eLogingHistory
        };

        public clsUsers() : base() { }
        public clsUsers( string FirstName, string LastName,string Email, string Phone,
            string AccountNumber, string Password, int Permessions) : base(FirstName,LastName,Phone,Email)
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

        static public bool isUserExist(string AccNumber)
        {
            return FindUser(AccNumber) != null;
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

        private string ConvertUserObjectToLine(clsUsers U, string Separator = "#//#")
        {
            ;
            return U._FirstName + Separator + U._LastName + Separator + U._Email + Separator + U._Phone + Separator +
             U._AccountNumber + Separator + U._Password + Separator + U._Permessions.ToString();
        }

        private bool AddDataLineToFile(string Line)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter writer = new StreamWriter(FilePath,true))
                {
                    writer.WriteLine(Line);
                }
                return true;
            }
            else
            {
                MessageBox.Show("Uses File Not Found");
                return false;
            }
        }

        public bool AddUser()
        {
            return AddDataLineToFile(ConvertUserObjectToLine(this));
        }

        private void SaveDataToFile(List<clsUsers> UsersList)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach(clsUsers U in UsersList)
                    {
                        if(U._MarkedForDelete == false)
                             writer.WriteLine(ConvertUserObjectToLine(U));
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Uses File Not Found");
            }
        }

        public bool UpdateUser()
        {
            List<clsUsers> UsersData = LoadUsersDataFromFile();

            for(short U = 0;U < UsersData.Count;U++)
            {
                if (UsersData[U]._AccountNumber == _AccountNumber)
                {
                    UsersData[U] = this;
                    break;
                }
            }

            SaveDataToFile(UsersData);
            return true;
        }


        public bool DeleteUser()
        {
            List<clsUsers> UsersData = LoadUsersDataFromFile();

            for (short U = 0; U < UsersData.Count; U++)
            {
                if (UsersData[U]._AccountNumber == _AccountNumber)
                {
                    UsersData[U]._MarkedForDelete = true;
                    break;
                }
            }

            SaveDataToFile(UsersData);
            return true;
        }



        public bool CheckPermissions(enPermession Permission)
            {
            if (this._Permessions == (int)enPermession.eAll) return true;

            else if ((this._Permessions & (int)Permission) == (int)Permission) 
                return true;

            else return false;
            }

/*
        void SaveToLoginHistory()
        {
            fstream File;
            File.open("LoginHistory.txt", ios::app);
            if (File.is_open())
            {
                File << _PrepareUserRecord() << endl;
                File.close();
            }

        }

        //--------------------------------
        static vector<vector<string>> GetLoginHistoryList()
        {
            vector<vector<string>> vUsers;
            string Line;
            fstream File;
            File.open("LoginHistory.txt", ios::in);
            if (File.is_open())
            {
                while (getline(File, Line))
                {
                    vUsers.push_back(clsString::Split(Line, "#//#"));
                }
                File.close();
            }
            return vUsers;
        }
*/

    }
}
