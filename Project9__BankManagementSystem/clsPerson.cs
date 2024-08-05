using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9__BankManagementSystem
{
    internal class clsPerson
    {
        public string _FirstName { set; get; }
        public string _LastName { set; get; }
        public string _Phone { set; get; }
        public string _Email { set; get; }

        public clsPerson(string FirstName, string LastName, string Phone, string Email)
        {
            _FirstName = FirstName;
            _LastName = LastName;
            _Phone = Phone;
            _Email = Email;
        }

        public clsPerson() { }
        public string GetFullName()
        {
            return _FirstName + ' ' + _LastName;
        } 


    }
}
