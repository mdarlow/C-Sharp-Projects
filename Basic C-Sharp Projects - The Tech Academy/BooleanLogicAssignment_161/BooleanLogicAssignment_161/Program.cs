using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment_161
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int usrAge = Convert.ToInt32(Console.ReadLine());
            bool over15 = Convert.ToBoolean(usrAge > 15);

            Console.WriteLine("Have you ever had a DUI?");
            bool usrDUI = Convert.ToBoolean(Console.ReadLine());
            bool noUsrDUI = Convert.ToBoolean(!usrDUI);
            
            Console.WriteLine("How many speeding tickets do you have?");
            int usrTickets = Convert.ToInt32(Console.ReadLine());
            bool lessThan3 = Convert.ToBoolean(usrTickets < 3);

            Console.WriteLine("Qualified?");
            bool usrQualified = Convert.ToBoolean(over15 && noUsrDUI && lessThan3);
            Console.WriteLine(usrQualified);

            Console.ReadLine();
        }
    }
}
