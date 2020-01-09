using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            float radius = -1;

            // Bonus #1
            //Console.WriteLine("Enter the radius of the circle:");
            //radius = float.Parse(Console.ReadLine());
            //if (radius < 0)
            //{
            //    Console.WriteLine("Error: must enter a positive number.");
            //}

            // Bonus #2
            while (radius < 0)
            {
                Console.WriteLine("Enter the radius of the circle:");
                radius = float.Parse(Console.ReadLine());
            }
            Console.WriteLine($"The area of a circle with radius {radius} is {Math.PI * radius * radius}");
            Console.ReadLine();
        }
    }
}
