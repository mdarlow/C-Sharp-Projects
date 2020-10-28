using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        List<int> integers = new List<int>() { 0, 12, 23, 34, 45, 56, 67, 78, 89, 910, 1011 };
        Console.WriteLine("Provide a number to divide each number in the list by.");


        try
        {
            int usrInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < integers.Count; i++)
            {
                Console.WriteLine(integers[i] / usrInput);
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by zero.");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter an integer.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Program has emerged from the try/catch block.");
            Console.ReadLine();
        }
    }
}
