using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment_183
{
    class Program
    {
        static void Main(string[] args)
        {


  ////////////////////////////////////
 ////////// Do-While Loop ///////////
////////////////////////////////////
            Console.WriteLine("What is the best dessert in the world?");
            string guess = Convert.ToString(Console.ReadLine());
            bool isGuessed = guess == "cheesecake";

            do
            {
                switch (guess)
                {
                    case "cake":
                        Console.WriteLine("Good guess, but ultimately incorrect.\nPlease try again.");
                        guess = Convert.ToString(Console.ReadLine());
                        break;
                    case "cheesecake":
                        Console.WriteLine("Cheesecake is correct!\nIt's the inherent best dessert ever!\nCongrats for understanding this universal truth!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("That is incorrect.\nPlease try again.");
                        guess = Convert.ToString(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();


  ////////////////////////////////////
 /////////// While Loop /////////////
////////////////////////////////////
            Console.WriteLine("Pick a number.");
            int numGuess = Convert.ToInt32(Console.ReadLine());
            bool numIsGuessed = false;

            while (!numIsGuessed)
            {
                switch (numGuess)
                {
                    case 9:
                        Console.WriteLine("Correct!");
                        numIsGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope, try again.");
                        numGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
