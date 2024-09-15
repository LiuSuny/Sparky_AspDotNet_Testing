using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sporty
{
    public class BankAccount
    {
        public int balance { get; set; } //public memeber
        public BankAccount() { }

        private readonly ILogBook _logBook;
        public BankAccount(ILogBook logbook)
        {
            _logBook = logbook;
            balance = 0;
        }

        public bool Deposit(int amount)
        {
            _logBook.Message("Balance Invoked ");
            _logBook.Message("Test");
            _logBook.LogSeverity = 101;
            var temp = _logBook.LogSeverity;
            balance += amount; //increasing the acct balance 
            return true;
        }

        public bool Withrdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
