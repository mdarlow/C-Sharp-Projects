using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment_247
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
        }
        public void Quit()
        {
            Console.WriteLine("Press enter to quit.");
        }
    }
}
