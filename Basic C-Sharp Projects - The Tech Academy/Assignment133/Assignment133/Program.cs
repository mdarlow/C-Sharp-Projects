using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment133
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            // What is your name?
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string needHelp = Console.ReadLine();
            bool help = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give us specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyhrs = Convert.ToInt32(studyHours);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

        }
    }
}
