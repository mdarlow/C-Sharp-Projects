using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutParameterAssignment_213
{
    class Program
    {
        static void Main(string[] args)
        {
            // User enters number:
            Console.WriteLine("Enter a number to be divided by two.");
            int usrInput = Convert.ToInt32(Console.ReadLine());

            // Instantiate class, call method, and display output:
            MathOperation.DivideByTwo(out int outParameter, usrInput);
            Console.WriteLine("\n{0} divided by 2 is {1}.", usrInput, outParameter);

            Console.ReadLine();
        }
    }

    // Create a class:
    public class MathOperation
    {

        // Create a void method that outputs an integer:
        public static void DivideByTwo(out int outParameter, int usrInput)
        {
            // Method divides data passed to it by 2:
            int answer = usrInput / 2;

            outParameter = answer;
        }

        // Create a method with output parameters & overload a method:
        public static void DivideByTwo(out decimal outParameter2, decimal usrInput2)
        {
            decimal answer = usrInput2 / 2;
            outParameter2 = answer;
        }
    }

    // Declare a class to be static:
    public static class SayHi
    {
        public static string Hello()
        {
            string greeting = "Hello!";
            return greeting;
        }
    }
}
