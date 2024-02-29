using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileProgram2
{
    internal class MobileProgram2
    {
        static void Main(string[] args)
        {
            Mobile jimMobile = new Mobile("Monthly", "Samsung Galaxy S6", "07712223344");
            Mobile jimMobile2 = new Mobile("PAYG", "Redmi mi 9T", "077123456987");

            jimMobile.setAccType("PAYG");
            jimMobile.setDevice("iphone 6S");
            jimMobile.setNumber("077133334466");
            jimMobile.setBalance(15.50);

            Console.WriteLine();
            Console.WriteLine("Account type: " + jimMobile.getAccType() + "\nMobile Number: "
                              + jimMobile.getNumber() + "\nDevice: " + jimMobile.getDevice()
                              + "\nBalance: " + jimMobile.getBalance());

            Console.WriteLine();
            jimMobile.addCredit(10.0);
            jimMobile.makeCall(5);
            jimMobile.sendText(2);


            Console.WriteLine();
            jimMobile2.setAccType("Monthly");
            jimMobile2.setDevice("Huawei Mate 20 pro");
            jimMobile2.setNumber("07723612011");
            jimMobile2.setBalance(20.50);

            Console.WriteLine();
            Console.WriteLine("Account type: " + jimMobile2.getAccType() + "\nMobile Number: "
                              + jimMobile2.getNumber() + "\nDevice: " + jimMobile2.getDevice()
                              + "\nBalance: " + jimMobile2.getBalance());

            Console.WriteLine();
            jimMobile2.addCredit(23.0);
            jimMobile2.makeCall(9);
            jimMobile2.sendText(10);

            Console.ReadLine();
        }
    }
}
