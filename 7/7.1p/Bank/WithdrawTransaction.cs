using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    class WithdrawTransaction : Transaction
    {
        // Instance variables
        private Account _account;

        /// Constructs a WithdrawTransaction
        public WithdrawTransaction(Account account, decimal amount) : base(amount)
        {
            _account = account;
        }

        /// Prints the details and status of the withdrawal
        public override void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1, 20}|{2, 20}|{3, 20}|",
                "ACCOUNT", "WITHDRAW AMOUNT", "STATUS", "CURRENT BALANCE");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, 20}|", _account.Name, _amount.ToString("C"));
            if (!Executed)
            {
                Console.Write("{0, 20}|", "Pending");
            }
            else if (Reversed)
            {
                Console.Write("{0, 20}|", "Withdraw reversed");
            }
            else if (Success)
            {
                Console.Write("{0, 20}|", "Withdraw complete");
            }
            else if (!Success)
            {
                Console.Write("{0, 20}|", "Insufficient funds");
            }
            Console.WriteLine("{0, 20}|", _account.Balance.ToString("C"));
            Console.WriteLine(new String('-', 85));
        }

        /// Executes the withdrawal
        /// when the withdraw is already complete or insufficient funds</exception>
        public override void Execute()
        {
            base.Execute();

            _success = _account.Withdraw(_amount);
            if (!_success)
            {
                throw new InvalidOperationException("Insufficient funds");
            }
        }

        /// Reverses the withdraw if previously executed successfully
        /// if already rolled back or if there are insufficient
        /// funds to complete the rollback</exception>
        public override void Rollback()
        {
            base.Rollback();
            bool complete = _account.Deposit(_amount); // Deposit returns boolean
            if (!complete) // Deposit didn't occur
            {
                throw new InvalidOperationException("Invalid amount");
            }
        }

        public override string GetAccountName()
        {
            return _account.Name;
        }
    }
}
