using System;
using TASK_1;
using static TASK_1.Bank;

namespace Task5_2P
{
    class TransferTransaction : ITransaction
    {
        // Public property to access the TransferTransactionBuilder
        public static TransferTransactionBuilder Builder => new TransferTransactionBuilder();
        public Account Account { get; private set; }
        public WithdrawTransaction WithdrawTransaction { get; private set; }
        public DepositTransaction DepositTransaction { get; private set; }

        // Instance variables
        private Account _fromAccount;
        private Account _toAccount;
        private decimal _amount;
        private DepositTransaction _deposit;
        private WithdrawTransaction _withdraw;
        private bool _executed;
        private bool _reversed;

        // Properties
        public bool Executed { get => _executed; }
        public bool Reversed { get => _reversed; }
        public bool Success { get => (_deposit.Success && _withdraw.Success); }


        // Constructor for a transfer transaction
        // Takes the account to transfer from, the account to transfer to, and the amount
        /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the amount is negative
        public TransferTransaction(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Negative transfer amount");
            }
            _amount = amount;

            _withdraw = new WithdrawTransaction(_fromAccount, _amount);
            _deposit = new DepositTransaction(_toAccount, _amount);
        }

        // Method to print the details of the transferr
        public void Print()
        {
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1, 20}|{2, 20}|{3, 20}|",
                "FROM ACCOUNT", "To ACCOUNT", "TRANSFER AMOUNT", "STATUS");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, 20}|{2, 20}|", _fromAccount.Name, _toAccount.Name, _amount.ToString("C"));
            if (!_executed)
            {
                Console.WriteLine("{0, 20}|", "Pending");
            }
            else if (_reversed)
            {
                Console.WriteLine("{0, 20}|", "Transfer reversed");
            }
            else if (Success)
            {
                Console.WriteLine("{0, 20}|", "Transfer complete");
            }
            else if (!Success)
            {
                Console.WriteLine("{0, 20}|", "Transfer failed");
            }
            Console.WriteLine(new String('-', 85));
        }


        // Method to execute the transfer
        /// <exception cref="System.InvalidOperationException">Thrown when previously executed or deposit or withdraw fail
        public void Execute()
        {
            if (_executed && Success)
            {
                throw new InvalidOperationException("Transfer previously executed");
            }
            _executed = true;

            try
            {
                _withdraw.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("Transfer failed with reason: " + exception.Message);
                _withdraw.Print();
            }

            if (_withdraw.Success)
            {
                try
                {
                    _deposit.Execute();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Transfer failed with reason: " + exception.Message);
                    _deposit.Print();
                    try
                    {
                        _withdraw.Rollback();
                    }
                    catch (InvalidOperationException e)
                    {
                        Console.WriteLine("Withdraw could not be reversed with reason: " + e.Message);
                        _withdraw.Print();
                    }
                }
            }
            Print();
            _deposit.Print();
            _withdraw.Print();
        }

        // Method to rollback the transfer
        /// <exception cref="System.InvalidOperationException">Thrown when the rollback has already been executed or it fails
        public void Rollback()
        {
            if (!_executed)
            {
                throw new InvalidOperationException("Transfer not executed. Nothing to rollback.");
            }

            if (_reversed)
            {
                throw new InvalidOperationException("Transfer already rolled back");
            }

            if (this.Success)
            {
                try
                {
                    _deposit.Rollback();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Failed to rollback deposit: "
                        + exception.Message);
                    return;
                }

                try
                {
                    _withdraw.Rollback();
                }
                catch (InvalidOperationException exception)
                {
                    Console.WriteLine("Failed to rollback withdraw: "
                        + exception.Message);
                    return;
                }
            }
            _reversed = true;
        }

        // Inner builder class for constructing TransferTransaction objects
        public class TransferTransactionBuilder
        {
            private Account _fromAccount;
            private Account _toAccount;
            private decimal _amount;

            // Method to set the 'from' account
            public TransferTransactionBuilder FromAccount(Account from)
            {
                if (from == null) throw new ArgumentNullException(nameof(from));
                _fromAccount = from;
                return this;
            }

            // Method to set the 'to' account
            public TransferTransactionBuilder ToAccount(Account to)
            {
                if (to == null) throw new ArgumentNullException(nameof(to));
                _toAccount = to;
                return this;
            }

            // Method to set the transfer amount
            public TransferTransactionBuilder Amount(decimal amount)
            {
                if (amount < 0) throw new ArgumentOutOfRangeException(
                    "Amount less than 0");
                _amount = amount;
                return this;
            }

            // Method to build the TransferTransaction object
            public TransferTransaction Build()
            {
                return new TransferTransaction(_fromAccount, _toAccount, _amount);
            }
        }

    }
}