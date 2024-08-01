using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9__BankManagementSystem
{
    internal class clsPerson
    {
        private string _FirstName { set; get; }
        private string _LastName { set; get; }
        private string _Phone { set; get; }
        private string _Email { set; get; }

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
