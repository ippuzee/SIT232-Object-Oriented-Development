using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        class Account
        {
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public int Balance { get; private set; }
            public Account(string firstName, string lastName, int balance)
            {
                FirstName = firstName;
                LastName = lastName;
                Balance = balance;
            }
            public void Withdraw(int amount)
            {
                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient fund");
                }
                Balance = Balance - amount;
            }

            private static void PrintExceptionDetails(Exception exception)
            {
                Console.WriteLine("The following error detected: " +
                    exception.GetType().ToString() + " with message \"" +
                    exception.Message + "\"");
            }


            static void Main(string[] args)
            {
                try
                {
                    Account account = new Account("Sergey", "P.", 100);
                    account.Withdraw(1000);
                }
                catch (InvalidOperationException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    // a) NullReferenceException
                    object obj = null;
                    int length = obj.ToString().Length;  // This line will throw NullReferenceException
                }
                catch (NullReferenceException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    // b) IndexOutOfRangeException
                    int[] array = { 1, 2, 3 };
                    int value = array[5];  // This line will throw IndexOutOfRangeException
                }
                catch (IndexOutOfRangeException ex)
                {
                    PrintExceptionDetails(ex);
                }

                

                try
                {
                    // d) OutOfMemoryException
                    AllocateMemory();  // This will eventually throw OutOfMemoryException
                }
                catch (OutOfMemoryException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    // e) InvalidCastException
                    object invalidCast = "Invalid Cast";
                    int result = (int)invalidCast;  // This line will throw InvalidCastException
                }
                catch (InvalidCastException ex)
                {
                    PrintExceptionDetails(ex);
                }

                // f) DivideByZeroException
                try
                {
                    int result = DivideByZeroExample(5, 0);  // This line will throw DivideByZeroException
                }
                catch (System.DivideByZeroException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    // g) ArgumentException
                    ProcessArgument(null);  // This will throw ArgumentException
                }
                catch (ArgumentException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    // h) ArgumentOutOfRangeException
                    ProcessIndex(-1);  // This will throw ArgumentOutOfRangeException
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    // i) SystemException
                    throw new SystemException("Custom System Exception");  // This will throw SystemException
                }
                catch (SystemException ex)
                {
                    PrintExceptionDetails(ex);
                }

                try
                {
                    // c) StackOverflowException
                    RecursiveMethod();  // This will eventually throw StackOverflowException
                }
                catch (StackOverflowException ex)
                {
                    PrintExceptionDetails(ex);
                }
            }

            static void RecursiveMethod()
            {
                RecursiveMethod();
            }

            static void AllocateMemory()
            {
                int[] largeArray = new int[int.MaxValue];
            }

            static void ProcessArgument(string value)
            {
                if (value == null)
                {
                    throw new ArgumentException("Argument cannot be null", nameof(value));
                }
            }
            static void ProcessIndex(int index)
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Index cannot be negative");
                }
            }

            static int DivideByZeroExample(int numerator, int denominator)
            {
                if (denominator == 0)
                {
                    throw new System.DivideByZeroException("Cannot divide by zero.");
                }

                return numerator / denominator;
            }
        }
    }
}


