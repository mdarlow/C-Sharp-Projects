using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
          //////////////
         // Part One //
        //////////////
        
        Console.WriteLine("PART ONE");
        
        string[] stringList = { "Super", "cali", "fragi", "listic", "expi", "ali", "docious" };
        Console.WriteLine("Please input some text to add to the end of each string in the list.");
        string usrInput = Convert.ToString(Console.ReadLine());

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(stringList[i] + usrInput);
        }
        Console.ReadLine();


          //////////////
         // Part Two //
        //////////////
        
        Console.WriteLine("PART TWO");
        
        //
         // Infinite Loop:
        //
        //for (int i = 0; i > -5; i++)
        //{
        //    Console.WriteLine("Infinite Loop");
        //}
        //Console.ReadLine();

          //
         // Fixed Loop:
        //
        Console.WriteLine("Previously infinite loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Finite Loop");
        }
        Console.ReadLine();


          ////////////////
         // Part Three //
        ////////////////
        
        Console.WriteLine("PART THREE");

          //
         // Iteration limitation: "<"
        //

        Console.WriteLine("Iteration limitation: \"<\"");

        var intList = Enumerable.Range(1, 500).ToList();
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(intList[i]);
        }
        Console.ReadLine();

          //
         // Iteration limitation: "<="
        //

        Console.WriteLine("Iteration limitation: \"<=\"");

        for (int x = 0; x <= 20; x++)
        {
            Console.WriteLine(intList[x]);
        }
        Console.ReadLine();


          ///////////////
         // Part Four //
        ///////////////
        
        Console.WriteLine("PART FOUR");

        List<string> foodList = new List<string>() { "Bananas", "Onions", "Sushi", "Cheesecake" };
        Console.WriteLine("What food item are you looking for in the food list?");
        string usrInput2 = Convert.ToString(Console.ReadLine());
        bool foodSelected = false;


        for (int i = 0; i < foodList.Count; i++)
        {
            if (foodList[i].Contains(usrInput2))
            {
                Console.WriteLine(i);
                foodSelected = true;
            }
        }
        if (foodSelected == false)
        {
            Console.WriteLine("Not in list.");
        }
        Console.ReadLine();


          ///////////////
         // Part Five //
        ///////////////

        Console.WriteLine("PART FIVE");

        List<string> things = new List<string>() { "Acorn", "Joy", "Paul", "Illustration", "Socks", "Joy" };
        Console.WriteLine("Select text to search for in the list.");
        string usrInput3 = Convert.ToString(Console.ReadLine());
        bool thingSelected = false;

        for (int i = 0; i < things.Count; i++)
        {
            if (things[i].Contains(usrInput3))
            {
                Console.WriteLine(i);
                thingSelected = true;
            }
        }
        if (!thingSelected)
        {
            Console.WriteLine("Not in list.");
        }
        Console.ReadLine();


          //////////////
         // Part Six //
        //////////////

        Console.WriteLine("PART SIX");

        List<string> stuff = new List<string>() { "Water", "Tortoise", "Star", "Cream", "Igloo", "Water", "1095" };
        List<string> stuff2 = new List<string>() { };
        string appearance = "";

        foreach (string item in stuff)
        {
            if (stuff2.Contains(item) == true)
            {
                appearance = "has already appeared in the list.";
            }
            else
            {
                appearance = "is currently unique in the list.";
            }
            Console.WriteLine("The item, {0}, {1}", item, appearance);
            stuff2.Add(item);
        }
        Console.ReadLine();
    }
}
