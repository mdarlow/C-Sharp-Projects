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
        
        string[] stringList = { "Super", "cali", "fragi", "listic", "expi", "ali", "docious" };
        Console.WriteLine("Please input some text.");
        string usrInput = Convert.ToString(Console.ReadLine());

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(stringList[i] + usrInput);
        }
        Console.ReadLine();


          //////////////
         // Part Two //
        //////////////
        
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
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Finite Loop");
        }
        Console.ReadLine();


          ////////////////
         // Part Three //
        ////////////////
        
          //
         // Iteration limitation: "<"
        //
        var intList = Enumerable.Range(1, 500).ToList();
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(intList[i]);
        }
        Console.ReadLine();

        for (int x = 0; x <= 20; x++)
        {
            Console.WriteLine(intList[x]);
        }
        Console.ReadLine();


          ///////////////
         // Part Four //
        ///////////////
        
        List<string> foodList = new List<string>() { "Bananas", "Onions", "Sushi", "Cheesecake" };
        Console.WriteLine("What food item are you looking for in the food list?");
        string usrInput2 = Convert.ToString(Console.ReadLine());
        bool foodSelected = false;

        do
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                if (foodList[i].Contains(usrInput2))
                {
                    Console.WriteLine(i);
                    foodSelected = true;
                }
            }
        }
        while (foodSelected == false);
        Console.ReadLine();
    }
}
