using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsAssignment_267
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number() { Amount = 2.5m };
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
