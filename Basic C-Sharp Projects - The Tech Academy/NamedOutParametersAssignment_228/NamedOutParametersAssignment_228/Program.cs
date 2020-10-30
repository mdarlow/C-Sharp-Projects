using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedOutParametersAssignment_228
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 3:
            int outParameters;
            MathOperation.TwoOperations(out int outparameter2, 1, 2);
            Console.WriteLine(outParameters);

            // Step 4:
            int namedParameters;
            MathOperation.TwoOperations(out int outParameter2, parameter1: 5, parameter2: 5);
            Console.WriteLine(namedParameters);

            Console.ReadLine();
        }
    }
    public class MathOperation
    {
        public static void TwoOperations(out int outParameter2, int parameter1 = 0, int parameter2 = 0)
        {
            // Step 1:
            // Math operation:
            int answerThatWillNeverBeSeen = parameter1 - 5 * 2;

            // So that the out parameter will work:
            outParameter2 = parameter2;
        }
    }
}
