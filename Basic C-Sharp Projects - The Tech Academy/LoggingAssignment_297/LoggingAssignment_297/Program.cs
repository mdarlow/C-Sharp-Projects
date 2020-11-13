using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggingAssignment_297
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for a number:
            Console.WriteLine("Please provide a number:");
            int aNumber = Convert.ToInt32(Console.ReadLine());

            // Log that number to a text file:
            string aTextFile = @"C:\Users\Michael Darlow\OneDrive\Desktop\FolderIWillDeleteAfterThisAssignment\aFile.txt";
            using (StreamWriter file = new StreamWriter(aTextFile, true))
            {
                file.WriteLine(aNumber);
            }

            // Print the text file back to the user:
            Console.WriteLine(aTextFile);
            Console.ReadLine();
        }
    }
}
