using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Task5_2P;

namespace TASK_1
{
    internal class Enum
    {
        public enum MenuOption
        {
            WITHDRAW = 1,
            DEPOSIT = 2,
            PRINT = 3,
            TRANSFER = 4,
            QUIT
        }

        public class Menu
        {
            // Main method to run the Menu
            public static void Run(Account myAccount, Account myAccount2)
            {
                MenuOption userChoice;
                do
                {
                    // display menu and get user's choice
                    userChoice = ReadUserOption();

                    // switch case will perform action based on user's choice
                    switch (userChoice)
                    {
                        case MenuOption.WITHDRAW:
                            {
                                DoWithdraw(myAccount);
                                break;
                            }
                        case MenuOption.DEPOSIT:
                            {
                                DoDeposit(myAccount);
                                break;
                            }
                        case MenuOption.PRINT:
                            {
                                DoPrint(myAccount, myAccount2);
                                break;
                            }
                        case MenuOption.TRANSFER:
                            {
                                DoTransfer(myAccount, myAccount2);
                                break;
                            }
                        case MenuOption.QUIT:
                            {
                                Console.WriteLine("Exiting the bank system. GoodBye!");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid option. Please choose a valid option.");
                                break;
                            }
                    }
                } while (userChoice != MenuOption.QUIT);
            }

            private static MenuOption ReadUserOption()
            {
                MenuOption userChoice;

                do
                {
                    //display menu
                    Console.WriteLine("\nMenu Options:");
                    Console.WriteLine("1. Withdraw");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Print");
                    Console.WriteLine("4. Transfer");
                    Console.WriteLine("5. Quit");

                    //prompting input from user
                    Console.WriteLine("Choose Choices (1 - 5): ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userInput2) && userInput2 >= 1 && userInput2 <= 5)
                    {
                        userChoice = (MenuOption)userInput2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option. Please enter from (1 - 5)");
                    }
                } while (true);
                return userChoice;
            }

            public static String ReadString(String prompt)
            {
                Console.Write(prompt + ": ");
                return Console.ReadLine();
            }

            public static int ReadInteger(String prompt)
            {
                int number = 0;
                string numberInput = ReadString(prompt);
                while (!(int.TryParse(numberInput, out number)))
                {
                    Console.WriteLine("Please enter a whole number");
                    numberInput = ReadString(prompt);
                }
                return Convert.ToInt32(numberInput);
            }


            public static int ReadInteger(String prompt, int minimum, int maximum)
            {
                int number = ReadInteger(prompt);
                while (number < minimum || number > maximum)
                {
                    Console.WriteLine("Please enter a whole number from " +
                                      minimum + " to " + maximum);
                    number = ReadInteger(prompt);
                }
                return number;
            }

            public static decimal ReadDecimal(String prompt)
            {
                decimal number = 0;
                string numberInput = ReadString(prompt);
                while (!(decimal.TryParse(numberInput, out number)) || number <= 0)
                {
                    Console.WriteLine("Please enter a decimal number greater than $0.00");
                    numberInput = ReadString(prompt);
                }
                return Convert.ToDecimal(numberInput);
            }

            private static void DoDeposit(Account account)
            {
                Console.WriteLine("Enter amount to deposit:");
                decimal amount = decimal.Parse(Console.ReadLine());

                DepositTransaction transaction = new DepositTransaction(account, amount);

                try
                {
                    // Execute the withdrawal transaction
                    transaction.Execute();
                    // Print transaction details
                    transaction.Print();
                    // Rollback (optional)
                    transaction.Rollback();
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }

            private static void DoWithdraw(Account account)
            {
                Console.Write("Enter the amount to withdraw: ");
                string amountInput = Console.ReadLine();

                if (decimal.TryParse(amountInput, out decimal amount))
                {
                    WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, amount);

                    // Execute the withdrawal transaction
                    withdrawTransaction.Execute();

                    // Print transaction details
                    withdrawTransaction.Print();

                    // Rollback (optional)
                    withdrawTransaction.Rollback();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric amount.");
                }
            }

            private static void DoPrint(Account account, Account account2)
            {
                account.Print(account, account2);
            }

            static void DoTransfer(Account fromAccount, Account toAccount)
            {
                decimal amount = ReadDecimal("Enter the amount");
                try
                {
                    TransferTransaction transfer = new TransferTransaction(fromAccount, toAccount, amount);
                    transfer.Execute();
                }
                catch (Exception)
                {
                    // Currently this is handled in the TransferTransaction. This will be changed
                }
            }
        }
    }
}
