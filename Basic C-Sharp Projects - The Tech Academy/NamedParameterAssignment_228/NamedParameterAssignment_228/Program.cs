using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameterAssignment_228
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperation.TwoOperations(1, 2);

            MathOperation.TwoOperations(parameter1: 5, parameter2: 56);

            Console.ReadLine();
        }
    }


    public class MathOperation
    {
        public static void TwoOperations(int parameter1 = 0, int parameter2 = 0)
        {
            int answerThatWillNeverBeSeen = parameter1 - 5 * 2;

            Console.WriteLine(parameter2);
        }
    }
}
