using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    internal class WithdrawTransaction 
    {
        private Account _account;
        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;
        private bool _reversed = false;
        

        public WithdrawTransaction(Account account, decimal amount)
        {
            _account = account ?? throw new ArgumentNullException(nameof(account));
            _amount = amount;
        }

        public void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1, 20}|{2, 20}|{3, 20}|",
                "ACCOUNT", "WITHDRAW AMOUNT", "STATUS", "CURRENT BALANCE");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, 20}|", _account.Name, _amount.ToString("C"));
            if (!_executed)
            {
                Console.Write("{0, 20}|", "Pending");
            }
            else if (_reversed)
            {
                Console.Write("{0, 20}|", "Withdraw reversed");
            }
            else if (_success)
            {
                Console.Write("{0, 20}|", "Withdraw complete");
            }
            else if (!_success)
            {
                Console.Write("{0, 20}|", "Insufficient funds");
            }
            Console.WriteLine("{0, 20}|", _account.balance.ToString("C"));
            Console.WriteLine(new String('-', 85));
        }

        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transaction has already been attempted.");
            }

            try
            {
                _account.Withdraw(_amount);
                
                if (_amount > 0 && _amount <= _account.balance )
                {
                    _success = true;
                }
                else
                {
                    _success = false;
                    throw new InvalidOperationException("Withdrawal amount exceeds account balance.");
                }
            }
            catch (InvalidOperationException )
            {
                _success = false;
                string errorMessage = "Withdrawal amount exceeds account balance. ";
                Console.WriteLine(errorMessage); // Print the error message to the console or log it
                //throw new InvalidOperationException(errorMessage, ex);
                
            }
            finally
            {
                _executed = true; // Mark the transaction as executed
            }
        }

        public void Rollback()
        {
            if (!_executed || _reversed)
            {
                throw new InvalidOperationException("Transaction cannot be rolled back.");
            }

            try
            {
                if (_success)
                {
                    _account.Deposit(_amount);
                    _reversed = true;
                    Console.WriteLine($"Transaction Status: Executed - {_executed}, Success - {_success}, Reversed - {_reversed}");
                }
                else
                {
                    throw new InvalidOperationException("Original transaction was not successful; cannot be rolled back.");
                }
            }
            catch (InvalidOperationException ex)
            {
                string errorMessage = "Rollback failed. " + ex.Message;
                Console.WriteLine(errorMessage); // Print the error message to the console or log it
                //throw new InvalidOperationException(errorMessage, ex);
            }
        }
        public decimal Amount => _amount;

        public Account Account => _account;

        public bool Executed => _executed;

        public bool Success => _success;

        public bool Reversed => _reversed;
    }
}
