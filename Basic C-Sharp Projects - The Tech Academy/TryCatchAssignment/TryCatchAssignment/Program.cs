using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate current date and time:
            DateTime currentDateAndTime = DateTime.Now;
            Console.WriteLine(currentDateAndTime);

            // Allows user to keep trying until compatible entry is made:
            while (true)
            {
                try
                {
                    Console.WriteLine("What is your age?");
                    int age = Convert.ToInt32(Console.ReadLine());

                    // if age is 0:
                    if (age == 0)
                    {
                        throw new ZeroException();
                    }

                    // if age is negative:
                    else if (age < 0)
                    {
                        throw new NegativeException();
                    }

                    // Display the year the user was born:
                    Console.WriteLine(currentDateAndTime.AddYears(-age).Year);
                    Console.ReadLine();
                    // Compatible entry has been made, so program will end:
                    return;
                }

                catch (ZeroException)
                {
                    // Error message for age = 0:
                    Console.WriteLine("The number cannot be zero. Please try a number greater than zero.");
                }

                catch (NegativeException)
                {
                    // Error message for age < 0:
                    Console.WriteLine("The number cannot be negative. Please try a number greater than zero.");
                }

                catch (Exception)
                {
                    // General exception:
                    Console.WriteLine("Error -- incompatible user entry. Please try again.");
                }
            }

        }
    }
}
