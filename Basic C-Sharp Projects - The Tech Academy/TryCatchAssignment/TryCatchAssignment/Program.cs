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
                    Console.WriteLine("\nWhat is your age?");
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
                    Console.WriteLine("You were born in {0}.", currentDateAndTime.AddYears(-age).Year);
                    Console.ReadLine();
                    // Compatible entry has been made, so program will end:
                    return;
                }

                catch (ZeroException)
                {
                    // Error message for age = 0:
                    Console.WriteLine("\nThe number cannot be zero. \nPlease try an integer greater than zero.");
                }

                catch (NegativeException)
                {
                    // Error message for age < 0:
                    Console.WriteLine("\nThe number cannot be negative. \nPlease try an integer greater than zero.");
                }

                catch (Exception)
                {
                    // General exception:
                    Console.WriteLine("\nError -- incompatible user entry. \n\nPlease try again and make sure that \nthe entry is a positive whole number \nwith no added characters or spaces.");
                }
            }

        }
    }
}
