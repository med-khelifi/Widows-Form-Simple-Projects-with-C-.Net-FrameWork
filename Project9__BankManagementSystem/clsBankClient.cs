using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project9__BankManagementSystem
{
    internal class clsBankClient : clsPerson
    {
        public string _AccountNumber { get; set; }
        public string _PinCode { get; set; }
        public double _Balance { get; set; }
        public bool _MarkedForDelete { get; set; } = false;

        private static string FilePath = "Clients.txt";

        private static string TransferLogFile = "TransferLogs.txt";
        public clsBankClient() : base() { }

        public clsBankClient(string FirstName, string LastName, string Email, string Phone,
            string AccountNumber, string PinCode, double Balance) : base(FirstName, LastName, Phone, Email)
        {
            _AccountNumber = AccountNumber;
            _PinCode = PinCode;
            _Balance = Balance;
        }

        public static clsBankClient FindClient(string AccNumber)
        {
            List<clsBankClient> FileData = LoadClientsDataFromFile();
            if (FileData != null)
            {
                foreach (clsBankClient Client in FileData)
                {
                    if (Client._AccountNumber == AccNumber) return Client;
                }
            }

            return null;
        }

        public static clsBankClient FindClient(string AccNumber, string PinCode)
        {
            List<clsBankClient> FileData = LoadClientsDataFromFile();
            if (FileData != null)
            {
                foreach (clsBankClient Client in FileData)
                {
                    if (Client._AccountNumber == AccNumber && Client._PinCode == PinCode) return Client;
                }
            }

            return null;
        }

        static public bool isClientExist(string AccNumber)
        {
            return FindClient(AccNumber) != null;
        }

        private static List<clsBankClient> LoadClientsDataFromFile()
        {
            if (File.Exists(FilePath))
            {
                List<clsBankClient> ClientsList = new List<clsBankClient>();

                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string Line;

                    while ((Line = sr.ReadLine()) != null)
                    {
                        var clientRecord = ConvertLineToClientRecord(Line);
                        if (clientRecord != null)
                        {
                            ClientsList.Add(clientRecord);
                        }
                    }
                }

                return ClientsList;
            }
            else
            {
                MessageBox.Show("Clients File Not Found");
                return null;
            }
        }

        private static clsBankClient ConvertLineToClientRecord(string Line)
        {
            string[] SplitedRecord = Line.Split(new string[] { "#//#" }, StringSplitOptions.None);

            if (SplitedRecord.Length != 7)
            {
                //MessageBox.Show($"Malformed line detected: {Line} + {SplitedRecord.Length}");
                return null;
            }

            return new clsBankClient(SplitedRecord[0], SplitedRecord[1], SplitedRecord[2], SplitedRecord[3], SplitedRecord[4], SplitedRecord[5], Convert.ToDouble(SplitedRecord[6]));
        }

        public static List<clsBankClient> GetClientsList()
        {
            return LoadClientsDataFromFile();
        }

        private string ConvertClientObjectToLine(clsBankClient C, string Separator = "#//#")
        {
            return C._FirstName + Separator + C._LastName + Separator + C._Email + Separator + C._Phone + Separator +
                   C._AccountNumber + Separator + C._PinCode + Separator + C._Balance.ToString();
        }

        private bool AddDataLineToFile(string Line)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
                {
                    writer.WriteLine(Line);
                }
                return true;
            }
            else
            {
                MessageBox.Show("Clients File Not Found");
                return false;
            }
        }

        public bool AddClient()
        {
            return AddDataLineToFile(ConvertClientObjectToLine(this));
        }

        private void SaveDataToFile(List<clsBankClient> ClientsList)
        {
            if (File.Exists(FilePath))
            {
                using (StreamWriter writer = new StreamWriter(FilePath))
                {
                    foreach (clsBankClient C in ClientsList)
                    {
                        if (C._MarkedForDelete == false)
                            writer.WriteLine(ConvertClientObjectToLine(C));
                    }
                }
            }
            else
            {
                MessageBox.Show("Clients File Not Found");
            }
        }

        public bool UpdateClient()
        {
            List<clsBankClient> ClientsData = LoadClientsDataFromFile();

            for (short U = 0; U < ClientsData.Count; U++)
            {
                if (ClientsData[U]._AccountNumber == _AccountNumber)
                {
                    ClientsData[U] = this;
                    break;
                }
            }

            SaveDataToFile(ClientsData);
            return true;
        }

        public bool DeleteClient()
        {
            List<clsBankClient> ClientsData = LoadClientsDataFromFile();

            for (short U = 0; U < ClientsData.Count; U++)
            {
                if (ClientsData[U]._AccountNumber == _AccountNumber)
                {
                    ClientsData[U]._MarkedForDelete = true;
                    break;
                }
            }

            SaveDataToFile(ClientsData);
            return true;
        }

       public bool Deposit(double Amount)
        {
            if (Amount < 1)
                return false;

            _Balance += Amount;
            UpdateClient();
            return true;
        }

        public bool WithDraw(double Amount)
        {
            if (Amount < 1)
                return false;

            _Balance -= Amount;
            UpdateClient();
            return true;
        }

        private string PrepareTransferRecord(clsBankClient receiver, double amount, string separator = "#//#")
        {
            string str = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + separator;
            str += _AccountNumber + separator + receiver._AccountNumber + separator;
            str += amount.ToString() ;

            return str;
        }

        private void SaveTransferOperation(clsBankClient receiver, double amount)
        {
            if (File.Exists(TransferLogFile))
            {
                using (StreamWriter file = new StreamWriter(TransferLogFile, true))
                {
                    file.WriteLine(PrepareTransferRecord(receiver, amount));
                }
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
            
        }

        public bool Transfer(ref clsBankClient receiver, double amount)
        {
            if (_Balance < amount) return false;

            this.WithDraw(amount);
            receiver.Deposit(amount);

            SaveTransferOperation(receiver, amount);
            return true;
        }

        public struct stTransfer
        {
            public string Date;
            public string SenderAccount;
            public string ReceiverAccount;
            public float Amount;
            
        }

        private static stTransfer ConvertLineToTransferRecord(string line)
        {
            stTransfer transfer = new stTransfer();
            string[] parts = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

            transfer.Date = parts[0];
            transfer.SenderAccount = parts[1];
            transfer.ReceiverAccount = parts[2];
            transfer.Amount = float.Parse(parts[3]);
            // Assuming there are more fields, add them here if needed
            // transfer.SenderBalance = float.Parse(parts[4]);
            // transfer.ReceiverBalance = float.Parse(parts[5]);
            // transfer.CurrentUserAccount = parts[6];

            return transfer;
        }

        public static List<stTransfer> GetTransferOperationList()
        {
            List<stTransfer> transferList = new List<stTransfer>();

            if (File.Exists("TransferLogs.txt"))
            {
                using (StreamReader file = new StreamReader("TransferLogs.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        transferList.Add(ConvertLineToTransferRecord(line));
                    }
                }
            }

            return transferList;
        }

    }
}
