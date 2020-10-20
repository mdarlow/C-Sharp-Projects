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
        string[] stringArray = new string[3];
        stringArray[0] = "Why, ";
        stringArray[1] = "hello ";
        stringArray[2] = "there.";

        Console.WriteLine("Select an index of the string array.");
        int stringArrayIndex = Convert.ToInt32(Console.ReadLine());

        while (stringArrayIndex < 0 || stringArrayIndex > 2)
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
        int[] intList = new int[5];
        intList[0] = 50;
        intList[1] = 64;
        intList[2] = 82;
        intList[3] = 91;
        intList[4] = 2147483647;

        Console.WriteLine("Select an index of the number array.");
        int intArrayIndex = Convert.ToInt32(Console.ReadLine());

        while (intArrayIndex < 0 || intArrayIndex > 4)
        {
            Console.WriteLine("Index does not exist within array. Please try again.");
            intArrayIndex = Convert.ToInt32(Console.ReadLine());
            continue;
        }
        Console.WriteLine(intList[intArrayIndex]);
        Console.ReadLine();

          /////////////////////
         // List of Strings //
        /////////////////////
        List<string> stringList = new List<string>();
        stringList.Add("Super");
        stringList.Add("cali");
        stringList.Add("fragil");
        stringList.Add("istic");
        stringList.Add("expi");
        stringList.Add("ali");
        stringList.Add("docious");

        Console.WriteLine("Select an index of the string list.");
        int stringListIndex = Convert.ToInt32(Console.ReadLine());

        while (stringListIndex < 0 || stringListIndex > 6)
        {
            Console.WriteLine("Index does not exist within list. Please try again.");
            stringListIndex = Convert.ToInt32(Console.ReadLine());
            continue;
        }
        Console.WriteLine(stringList[stringListIndex]);
        Console.ReadLine();
    }
}

