using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem2
{
    internal class BankSystem : Enum 
    {
        static void Main(string[] args)
        {
            Menu.Run();
            Console.ReadLine();
        }
    }
}
