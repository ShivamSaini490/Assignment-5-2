using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        try
        {
            int index = 10; 
            int value = numbers[index];
            Console.WriteLine("Value at index " + index + ": " + value);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            
        }

        Console.WriteLine("Program continues...");
    }
}
