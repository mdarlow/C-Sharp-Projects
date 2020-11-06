// Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment_252
{
    class Program
    {
        static void Main(string[] args)
        {
              /////////////////////////////
             /// Instances of Employee ///
            /////////////////////////////
            Employee employee1 = new Employee();
            employee1.Id = 1;
            Employee employee2 = new Employee();
            employee2.Id = 2;

              /////////////////////////////
             /// Compare Id properties ///
            /////////////////////////////
            Console.WriteLine(employee1.Id == employee2.Id);
            Console.ReadLine();
        }
    }
}
