using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationMethodsAssignment_223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide a number for the math operations to be performed on.");
            int usrInput = Convert.ToInt32(Console.ReadLine());

            // Method #1
            // Division class ==> DivideByThree method
            Console.WriteLine("{0} \u00F7 3 = {1}.", usrInput, MathOperations.DivideByThree(usrInput));
            Console.ReadLine();

            // Method #2
            // Multiplication class ==> MultiplyByThree method
            Console.WriteLine("{0} X 3 = {1}.", usrInput, MathOperations.MultiplyByThree(usrInput));
            Console.ReadLine();

            // Method #3
            // Addition class ==> AddThree method
            Console.WriteLine("{0} + 3 = {1}.", usrInput, MathOperations.AddThree(usrInput));
            Console.ReadLine();
        }
    }
}
