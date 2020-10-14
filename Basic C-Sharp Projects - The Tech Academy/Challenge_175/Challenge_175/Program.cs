using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_175
{
    class Program
    {
        static void Main(string[] args)
        {
            int usr1Age = 20;
            int usr2Age = 30;

            string result = usr1Age > usr2Age ? "User 1 is older than User 2." : "User 1 is younger than User 2.";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
