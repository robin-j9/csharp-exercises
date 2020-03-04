using System;

namespace ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq1 = new Square() { Length = 4, Width = 4 };
            Console.WriteLine(sq1.CalculateArea());
            Console.WriteLine(sq1.CalculateCircumference());

            Rectangle rect1 = new Rectangle() { Length = 5.2, Width = 3.3 };
            Console.WriteLine(rect1.CalculateArea());

            Circle circle1 = new Circle() { Radius = 3.4 };
            Console.WriteLine(circle1.CalculateArea());
            Console.WriteLine(circle1.CalculateCircumference());

            Console.WriteLine(sq1.Id);
            Console.WriteLine(rect1.Id);
            Console.WriteLine(circle1.Id);
        }
    }
}
