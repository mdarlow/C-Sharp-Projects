using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment_178
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight:");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal packageQuote = (packageWidth * packageHeight * packageLength * packageWeight) / 100;
                    string packageQuote2Decimals = String.Format("{0:.00}", packageQuote);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + packageQuote2Decimals + "\nThank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
