using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Divinding the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        }
        // Catching a FormatException and assigning it to variable ex:
        catch (FormatException ex)
        {
            // Message of the variable ex error:
            // Console.WriteLine(ex.Message);

            // My own error message:
            Console.WriteLine("Please enter an integer.");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        // If it's any other exception:
        catch (Exception ex)
        {
            // Display C#'s error message:
            Console.WriteLine(ex.Message);
        }
        // Runs no matter what:
        finally
        {
            Console.ReadLine();
        }
    }
}
