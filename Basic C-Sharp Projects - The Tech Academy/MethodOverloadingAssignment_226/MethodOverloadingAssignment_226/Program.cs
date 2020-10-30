using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingAssignment_226
{
    class Program
    {
        static void Main(string[] args)
        {
            int minuend1 = 10;
            double minuend2 = 10.258;
            string minuend3 = "10";
            Console.WriteLine("Integer to integer:");
            Console.WriteLine("{0} - 3 = {1}", minuend1, MathOperation.SubtractByThree(minuend1));
            Console.WriteLine("\nDecimal to integer:");
            Console.WriteLine("{0} - 3 = {1}", minuend2, MathOperation.SubtractByThree(minuend2));
            Console.WriteLine("\nString to integer:");
            Console.WriteLine("{0} - 3 = {1}", minuend3, MathOperation.SubtractByThree(minuend3));
            Console.ReadLine();
        }
    }


    class MathOperation
    {
        public static int SubtractByThree(int minuend1)
        {
            int difference = minuend1 - 3;
            return difference;
        }

        public static int SubtractByThree(double minuend2)
        {
            int convertedMinuend2 = Convert.ToInt32(minuend2);
            int difference = convertedMinuend2 - 3;
            return difference;
        }

        public static int SubtractByThree(string minuend3)
        {
            int convertedMinuend3 = Convert.ToInt32(minuend3);
            int difference = convertedMinuend3 - 3;
            return difference;
        }
    }
}
