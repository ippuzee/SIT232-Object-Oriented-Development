using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem2
{
    internal class Enum 
    {
        public enum MenuOption
        {
            WITHDRAW = 1,
            DEPOSIT = 2,
            PRINT = 3,
            QUIT
        }

        public class Menu
        {
            // Main method to run the Menu
            public static void Run()
            {
                Account myAccount = new Account("Bruce Wayne", 150000m);

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
                                myAccount.Withdraw();
                                break;
                            }
                        
                        case MenuOption.DEPOSIT:
                            {
                                myAccount.Deposit(); 
                                break;
                            }
                        case MenuOption.PRINT:
                            {
                                myAccount.Print(); 
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
                    Console.WriteLine("4. Quit");

                    //prompting input from user
                    Console.WriteLine("Choose Choices (1 - 4): ");
                    string userInput = Console.ReadLine();
                    int userInput2 = Convert.ToInt32(userInput);

                    if (userInput2 >= 1 && userInput2 <= 4)
                    {
                        userChoice = (MenuOption)userInput2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option. Please enter from (1 - 4)");
                    }
                } while (true );
                return userChoice;   
            }
        }
    }
}
