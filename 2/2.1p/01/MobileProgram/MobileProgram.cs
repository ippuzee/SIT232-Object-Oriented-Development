using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProgram
{
    internal class MobileProgram
    {
        static void Main(string[] args)
        {
            Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");

            jimMobile.setAccType("PAYG");
            jimMobile.setDevice("iphone 6S");
            jimMobile.setNumber("077133334466");
            jimMobile.setBalance(15.50);

            Console.WriteLine();
            Console.WriteLine("Account type: "+jimMobile.getAccType() + "\nMobile Number: "
                              + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice()
                              + "\nBalance: "+ jimMobile.getBalance() );

            Console.WriteLine();
            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);
            Console.ReadLine();
        }
    }
}
