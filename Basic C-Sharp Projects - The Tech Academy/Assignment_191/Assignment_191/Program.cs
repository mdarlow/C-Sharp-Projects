using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
          //////////////////////
         // Array of Strings //
        //////////////////////
        string[] stringArray = {"Why, ", "hello ", "there."};
        Console.WriteLine("Select an index of the string array.");
        int stringArrayIndex = Convert.ToInt32(Console.ReadLine());

        while (stringArrayIndex < 0 || stringArrayIndex >= stringArray.Length)
        {
            Console.WriteLine("Index does not exist within array. Please try again.");
            stringArrayIndex = Convert.ToInt32(Console.ReadLine());
            continue;
        }
        Console.WriteLine(stringArray[stringArrayIndex]);
        Console.ReadLine();

          ///////////////////////
         // Array of Integers //
        ///////////////////////
        int[] intArray = {50, 64, 82, 91, 2147483647};
        Console.WriteLine("Select an index of the number array.");
        int intArrayIndex = Convert.ToInt32(Console.ReadLine());

        while (intArrayIndex < 0 || intArrayIndex >= intArray.Length)
        {
            Console.WriteLine("Index does not exist within array. Please try again.");
            intArrayIndex = Convert.ToInt32(Console.ReadLine());
            continue;
        }
        Console.WriteLine(intArray[intArrayIndex]);
        Console.ReadLine();

          /////////////////////
         // List of Strings //
        /////////////////////
        List<string> stringList = new List<string>() {"Super", "cali", "fragi", "listic", "expi", "ali", "docious"};
        Console.WriteLine("Select an index of the string list.");
        int stringListIndex = Convert.ToInt32(Console.ReadLine());

        while (stringListIndex < 0 || stringListIndex >= stringList.Count)
        {
            Console.WriteLine("Index does not exist within list. Please try again.");
            stringListIndex = Convert.ToInt32(Console.ReadLine());
            continue;
        }
        Console.WriteLine(stringList[stringListIndex]);
        Console.ReadLine();
    }
}

