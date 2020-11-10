using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment_272
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            

            Employee employee1;
            employee1.employeeId = 1;
            employee1.firstName = "Joe";
            employee1.lastName = "Seff";
            employees.Add(employee1);

            Employee employee2;
            employee2.employeeId = 2;
            employee2.firstName = "Sam";
            employee2.lastName = "Sung";
            employees.Add(employee2);

            Employee employee3;
            employee3.employeeId = 3;
            employee3.firstName = "Ronald";
            employee3.lastName = "MacDonald-Berger";
            employees.Add(employee3);

            Employee employee4;
            employee4.employeeId = 4;
            employee4.firstName = "Lois";
            employee4.lastName = "Price";
            employees.Add(employee4);

            Employee employee5;
            employee5.employeeId = 5;
            employee5.firstName = "Ali";
            employee5.lastName = "Gater";
            employees.Add(employee5);

            Employee employee6;
            employee6.employeeId = 6;
            employee6.firstName = "Holly";
            employee6.lastName = "Wood";
            employees.Add(employee6);

            Employee employee7;
            employee7.employeeId = 7;
            employee7.firstName = "Justin";
            employee7.lastName = "Thyme";
            employees.Add(employee7);

            Employee employee8;
            employee8.employeeId = 8;
            employee8.firstName = "Maxy";
            employee8.lastName = "Mumm";
            employees.Add(employee8);

            Employee employee9;
            employee9.employeeId = 9;
            employee9.firstName = "Joe";
            employee9.lastName = "King";
            employees.Add(employee9);

            Employee employee10;
            employee10.employeeId = 10;
            employee10.firstName = "Ima";
            employee10.lastName = "Dunn";
            employees.Add(employee10);
            

            List<Employee> fNameJoe = new List<Employee>();
            
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    fNameJoe.Add(employee.employeeId);
                    fNameJoe.Add(employee.lastName);
                    fNameJoe.Add(employee.lastName);
                }
            }
            foreach (Employee name in fNameJoe)
            {
                Console.WriteLine(name);
            }












            //////////////////////////////////////////////////
            // Instantiate Employee object with type string //
            //////////////////////////////////////////////////

            //Employee<string> employeeStringList = new Employee<string>();
            //employeeStringList.things = new List<string> { };
            //employeeStringList.things.Add("asdf");
            //employeeStringList.things.Add("ghjk");
            //employeeStringList.things.Add("l;\'");

            ///////////////////////////////////////////////
            // Instantiate Employee object with type int //
            ///////////////////////////////////////////////

            //Employee<int> employeeIntList = new Employee<int>();
            //employeeIntList.things = new List<int> { };
            //employeeIntList.things.Add(1);
            //employeeIntList.things.Add(2);
            //employeeIntList.things.Add(3);


            //Console.WriteLine("Strings in Things:");
            //foreach (var thing in employeeStringList.things)
            //{
            //    Console.WriteLine(thing);
            //}

            //Console.WriteLine("Integers in Things:");
            //foreach (var thing in employeeIntList.things)
            //{
            //    Console.WriteLine(thing);
            //}

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
