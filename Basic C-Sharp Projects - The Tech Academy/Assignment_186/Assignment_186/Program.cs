using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_186
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Michael";
            string verb = " said, ";
            string quote = "\"Hello!\"";

            name = name.ToUpper();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Michael. ");
            sb.Append("My last name is Darlow. ");
            sb.Append("That's like \"Barlow,\" but even better.");

            Console.WriteLine(name + verb + quote);
            Console.WriteLine("\n" + sb);
            Console.ReadLine();
        }
    }
}
