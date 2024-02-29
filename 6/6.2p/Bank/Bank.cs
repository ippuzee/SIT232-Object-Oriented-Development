using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5_2P;

namespace TASK_1
{
    
    internal class Bank
    {
        private readonly List<Account> _accounts;

        public interface ITransaction
        {
            Account Account { get; }
            WithdrawTransaction WithdrawTransaction { get; }
            DepositTransaction DepositTransaction { get; }
            void Execute();
        }

        // Creates an empty bank object with a list for accounts
        public Bank()
        {
            _accounts = new List<Account>();
        }

        // Adds an account to the Bank accounts register
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        // Returns to the first Account corresponding to the name, or
        // null if there is no account matching the criteria
        public Account GetAccount(string name)
        {
            return _accounts.FirstOrDefault(a => a.Name == name);
        }

        // Executes a deposit into an account
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            if (_accounts.Contains(transaction.GetAccount()))
            {
                transaction.Execute();
            }
            else
            {
                Console.WriteLine("Error: Account not found.");
            }
        }

        // Executes a WithdrawTransaction on an account
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            if (_accounts.Contains(transaction._account))
            {
                transaction.Execute();
            }
            else
            {
                Console.WriteLine("Error: Account not found.");
            }
        }

        // Transfers funds between accounts held by the bank
        public void ExecuteTransaction(TransferTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occured in executing the transaction");
                Console.WriteLine("The error was: " + exception.Message);
            }
        }
    }
}
