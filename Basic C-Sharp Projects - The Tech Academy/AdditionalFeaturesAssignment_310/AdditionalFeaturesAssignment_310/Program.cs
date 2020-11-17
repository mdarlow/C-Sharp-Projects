using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment_310
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constVar = "This is a \"constant variable\"";

            var keywordVar = "This is an implicitly typed variable";

            Console.WriteLine("{0}.\n{1}.", constVar, keywordVar);

            Person newPerson = new Person("Bob");

            Console.ReadLine();

        }

    }

    internal class Person
    {
        private string favColor;
        private string Name;

        public Person(string name) : this(name, "blue")
        {
        }
        public Person(string name, string color)
        {
            favColor = color;
            Name = name;
            Console.WriteLine("{0}\'s favorite color is {1}.", Name, favColor);
        }
    }
}
