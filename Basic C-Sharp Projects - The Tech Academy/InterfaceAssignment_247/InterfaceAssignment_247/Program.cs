﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment_247
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //employee.SayName();
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();
        }
    }
}