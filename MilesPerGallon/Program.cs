using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            int miles = int.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons have you used?");
            int gallons = int.Parse(Console.ReadLine());

            Console.WriteLine("Your miles per gallon is: " + (miles / gallons));
        }
    }
}
