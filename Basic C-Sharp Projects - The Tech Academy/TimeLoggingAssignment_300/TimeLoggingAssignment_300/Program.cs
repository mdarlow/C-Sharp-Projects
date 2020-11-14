using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimeLoggingAssignment_300
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console:
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            // Ask the user for a number:
            Console.WriteLine("Please enter a number:");
            int aNumber = Convert.ToInt32(Console.ReadLine());

            // Print to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine(currentDateAndTime.AddHours(aNumber));
            Console.ReadLine();

        }
    }
}
