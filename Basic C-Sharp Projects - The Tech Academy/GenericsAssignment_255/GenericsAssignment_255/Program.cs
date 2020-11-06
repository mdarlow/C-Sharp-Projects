using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment_255
{
    class Program
    {
        static void Main(string[] args)
        {
              //////////////////////////////////////////////////
             // Instantiate Employee object with type string //
            //////////////////////////////////////////////////

            Employee<string> employeeStringList = new Employee<string>();
            employeeStringList.things = new List<string> { };
            employeeStringList.things.Add("asdf");
            employeeStringList.things.Add("ghjk");
            employeeStringList.things.Add("l;\'");

              ///////////////////////////////////////////////
             // Instantiate Employee object with type int //
            ///////////////////////////////////////////////

            Employee<int> employeeIntList = new Employee<int>();
            employeeIntList.things = new List<int> { };
            employeeIntList.things.Add(1);
            employeeIntList.things.Add(2);
            employeeIntList.things.Add(3);


            Console.WriteLine("Strings in Things:");
            foreach (var thing in employeeStringList.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("Integers in Things:");
            foreach (var thing in employeeIntList.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();



            //Employee employee1 = new Employee();
            //employee1.Id = 1;
            //Employee employee2 = new Employee();
            //employee2.Id = 2;
            
            //Console.WriteLine(employee1 == employee2);
            //Console.ReadLine();
        }
    }
}
