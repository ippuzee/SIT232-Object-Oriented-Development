using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort
{
    internal class Program : AccountSorter
    {
        static void Main(string[] args)
        {
            // Test the implementation with an array of Account objects
            Account[] accountArray = 
            {
                new Account {  Name = "Nirosh", Balance = 500 },
                new Account {  Name = "Baxy  ", Balance = 200 },
                new Account {  Name = "Bison ", Balance = 700 },
                new Account {  Name = "Bruce ", Balance = 300 }
            };

            Console.WriteLine("Original Array:");
            PrintAccounts(accountArray);
            
            // Sort the array using AccountsSorter.Sort
            AccountsSorter.Sort(accountArray, 3);

            Console.WriteLine("Sorted Array:");
            PrintAccounts(accountArray);

            // Test the implementation with a List of Account objects
            List<Account> accountList = new List<Account>
            {
                new Account { Name = "Tony "  },// if a null value is given as account balance, it will be set to 0 by default.
                new Account { Name = "Steve",  Balance = 100 },
                new Account { Name = "Clark",  Balance = 600 },
                new Account { Name = "Clint",  Balance = 400 }
            };

            Console.WriteLine("Original List:");
            PrintAccounts(accountList);

            // Sort the list using AccountsSorter.Sort
            AccountsSorter.Sort(accountList, 3);

            Console.WriteLine("Sorted List:");
            PrintAccounts(accountList);

            Console.WriteLine("Bucket Sort implementation tested successfully.");
            Console.ReadLine();
        }

        // Helper method to print accounts
        static void PrintAccounts(IEnumerable<Account> accounts)
        {
            foreach (var acc in accounts)
            {
                Console.WriteLine($"Name: {acc.Name} - Balance: {acc.Balance}");
            }
            Console.WriteLine();
        }

        
    }
}
