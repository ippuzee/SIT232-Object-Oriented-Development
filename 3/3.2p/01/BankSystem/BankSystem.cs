using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class BankSystem
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account("Bruce Wayne", 150000m);

            myAccount.Deposit(-10000);// invalid deposit
            myAccount.Deposit(10000);// valid deposit

            myAccount.Withdraw(-10000);//invalid withdraw
            myAccount.Withdraw(170000);//invalid withdraw
            myAccount.Withdraw(50000);// valid withdraw

            myAccount.Print();
            Console.ReadLine();
        }
    }
}
