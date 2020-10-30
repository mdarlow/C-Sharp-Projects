using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterAssignment_227
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For exponentiation, please input one base number and then one exponent. Exponent will default to \"2\" if left blank.");
            double inputBase = Convert.ToInt32(Console.ReadLine());
            string inputExponent = Console.ReadLine();

            if (inputExponent == "")
            {
                Console.WriteLine("{0} ^ {1} = {2}", inputBase, 2, MathOperation.Exponentiation(inputBase));
            }
            else
            {
                double convertedExponent = Convert.ToDouble(inputExponent);
                Console.WriteLine("{0} ^ {1} = {2}", inputBase, inputExponent, MathOperation.Exponentiation(inputBase, convertedExponent));
            }
            Console.ReadLine();

        }
        class MathOperation
        {
            public static int Exponentiation(double inputBase, double convertedExponent = 2)
            {
                int power = Convert.ToInt32(Math.Pow(inputBase, convertedExponent));
                return power;
            }
        }
    }
}
