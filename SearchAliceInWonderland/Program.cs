using System;

namespace SearchAliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string wonderland = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("What would you like to search for in 'Alice in Wonderland'?");
            string searchTerm = Console.ReadLine().ToLower();
            if (wonderland.ToLower().IndexOf(searchTerm) != -1)
            {
                Console.WriteLine("Search term found!");
            }
            else
            {
                Console.WriteLine("Search term not found!");
            }
        }
    }
}
