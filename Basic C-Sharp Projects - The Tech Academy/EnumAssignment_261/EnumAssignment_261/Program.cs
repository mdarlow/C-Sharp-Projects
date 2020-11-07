using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumAssignment_261
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the current day of the week.");
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());
                Console.WriteLine("Happy {0} to you!", currentDay);
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();

        }

          //////////
         // Enum //
        //////////
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
