using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TASK_1
{

    class Account
    {
        // Read-only properties
        public String Name { get; private set; }
        public decimal Balance { get; private set; }


        /// Class constructor
        public Account(String name, decimal balance = 0)
        {
            Name = name;
            if (balance < 0) return;
            Balance = balance;
        }

        /// Deposits money into the account
        /// Boolean whether the deposit was successful (true) or not (false)
        public Boolean Deposit(decimal amount)
        {
            if ((amount < 0) || (amount == decimal.MaxValue))
                return false;

            Balance += amount;
            return true;
        }

        /// Withdraws money from the account (with no overdraw protection currently)
        /// Boolean whether the withdrawal was successful (true) or not (false)
        public Boolean Withdraw(decimal amount)
        {
            if ((amount < 0) || (amount > Balance))
                return false;

            Balance -= amount;
            return true;
        }

        /// Outputs the account name and current balance as a string
        public void Print()
        {
            Console.WriteLine("Account Name: {0}, Balance: {1}",
                Name, Balance.ToString("C"));
        }

    }
}
