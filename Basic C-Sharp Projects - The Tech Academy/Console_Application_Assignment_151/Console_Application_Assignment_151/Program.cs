using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Assignment_151
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter integer:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            int times50 = userInput * 50;
            Console.WriteLine("Input times 50 is " + times50);

            int add25 = userInput + 25;
            Console.WriteLine("Input plus 25 is " + add25);

            double divide12_5 = userInput / 12.5;
            Console.WriteLine("Input divided by 12.5 is " + divide12_5);

            bool isGreaterThan50 = userInput > 50;
            Console.WriteLine("The phrase, \"Input is greater than 50\" is " + isGreaterThan50);

            int remainder7 = userInput % 7;
            Console.WriteLine("Remainder of input divided by 7 is " + remainder7);

            Console.ReadLine();
        }
    }
}
