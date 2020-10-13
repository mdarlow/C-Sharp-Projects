using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorsAssignment_152
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\nPerson 1\nHourly Rate?");
            int p1HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p1HoursWorked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2\nHourly rate?");
            int p2HourlyRate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int p2HoursWorked = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Annual salary of Person 1:");
            int p1Salary = p1HourlyRate * p1HoursWorked * 56;
            Console.WriteLine(p1Salary);
            
            Console.WriteLine("Annual salary of Person 2:");
            int p2Salary = p2HourlyRate * p2HoursWorked * 56;
            Console.WriteLine(p2Salary);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool p1MoreThanp2 = Convert.ToBoolean(p1Salary > p2Salary);
            Console.WriteLine(p1MoreThanp2);

            Console.ReadLine();
        }
    }
}
