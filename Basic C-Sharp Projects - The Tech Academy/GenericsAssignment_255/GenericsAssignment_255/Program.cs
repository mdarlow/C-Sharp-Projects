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
            employeeStringList.Add("asdf");
            employeeStringList.Add("ghjk");
            employeeStringList.Add("l;\'");

              ///////////////////////////////////////////////
             // Instantiate Employee object with type int //
            ///////////////////////////////////////////////
            Employee<int> employeeIntList = new Employee<int>();
            employeeIntList.Add(1);
            employeeIntList.Add(2);
            employeeIntList.Add(3);

            foreach (Employee<string> thing in Employee<string>.Things)
            {
                Console.WriteLine(thing);
            }




            //Employee employee1 = new Employee();
            //employee1.Id = 1;
            //Employee employee2 = new Employee();
            //employee2.Id = 2;
            
            //Console.WriteLine(employee1 == employee2);
            //Console.ReadLine();
        }
    }
}
