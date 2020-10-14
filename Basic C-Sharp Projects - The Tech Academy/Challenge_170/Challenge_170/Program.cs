using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_170
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater than num2.");
            }
            else
            {
                Console.WriteLine("num2 is greater than num1.");
            }

            int books = 51;
            if (books <= 50)
            {
                Console.WriteLine("That is not too many books.");
            }
            else
            {
                Console.WriteLine("That is too many books.");
            }

            Console.ReadLine();
        }
    }
}
