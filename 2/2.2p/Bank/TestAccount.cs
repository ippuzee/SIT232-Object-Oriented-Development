using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class TestAccount
    {
        static void Main(string[] args)
        {
            Account account = new Account("Bruce Wayne", 150000.0m);

            account.Print();
            account.Deposit(1000.0m);
            account.Withdraw(10000.0m);
            account.Print();
            Console.ReadLine();

        }
    }
}
