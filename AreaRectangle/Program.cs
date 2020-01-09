using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the rectangle width?");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the rectangle length?");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("The area of the rectangle is: " + (width * length));
            //string interpolation
            Console.WriteLine($"The area of the rectangle is: {width * length}");
        }
    }
}
