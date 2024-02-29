using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Account object created
            Account myAccount = new Account("Bruce Wayne", 150000m);
            Account myAccount2 = new Account("Tony Stark", 90000m);

            Enum.Menu.Run(myAccount, myAccount2);
            Console.ReadLine();
        }
    }
}
