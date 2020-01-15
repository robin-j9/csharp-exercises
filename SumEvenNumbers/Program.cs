using System;
using System.Collections.Generic;

namespace SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 15, 22, 25, 13, 18, 6, 10 };
            List<int> numbers = new List<int>(nums);
            Console.WriteLine(Program.SumEven(numbers));
        }

        static int SumEven(List<int> numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
