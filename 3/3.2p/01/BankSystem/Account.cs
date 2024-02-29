using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Account
    {

        private decimal balance;
        private String name;

        //constructor
        public Account(String name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        //deposit method
        public bool Deposit(decimal amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine();
                Console.WriteLine($"Amount deposited successfully");
                Console.WriteLine($"Account Balance after Depositing {amount} LKR: {balance} LKR");
                return true; // deposit is a success
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for deposit {amount}");
                Console.WriteLine("Invalid deposit amount. Please enter a positive value"); 
                return false; // deposit failed 
            }
        }

        //withdraw method
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine() ;
                Console.WriteLine("Withdraw successful");
                Console.WriteLine($"Account Balance after Withdrawing {amount} LKR: {balance} LKR");
                return true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for withdrawal {amount}");
                Console.WriteLine("Your account has Insufficient balance or Ivalid withdrawal amount. Please enter a positive value.");
                return false;
            }
        }

        // method to print the name and balance
        public void Print()
        {
            Console.WriteLine("");
            Console.WriteLine($"Account Holder Name: {name}");
            Console.WriteLine($"Account Balance: {balance} LKR");
        }

        // property to get account name
        public String Name
        {
            get
            {
                return name;
            }
        }
    }
}
