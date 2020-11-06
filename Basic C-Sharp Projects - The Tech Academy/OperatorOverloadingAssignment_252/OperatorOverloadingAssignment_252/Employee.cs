using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment_252
{
    public class Employee : Person, IQuittable
    {
        public int Id
        {
            get; set;
        }
        public override void SayName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Press enter to quit.");
        }
        
          //////////////////////////////
         /// Overload "==" operator ///
        //////////////////////////////
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
    }
}
