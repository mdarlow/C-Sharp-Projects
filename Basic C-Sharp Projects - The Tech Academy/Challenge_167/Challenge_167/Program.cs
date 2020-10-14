using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_167
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());
                        
            if(favNum != 13)
            {
                Console.WriteLine("Good choice!");
            }
            else
            {
                Console.WriteLine("The CPU is superstitious. Please pick a different number.");
            }
            Console.ReadLine();
        }
    }
}
