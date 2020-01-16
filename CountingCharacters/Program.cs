using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string textBlock = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            
            // Bonus 3
            Console.WriteLine("Enter string:");
            string textBlock = Console.ReadLine();

            // Bonus 1
            textBlock = textBlock.ToLower();
            
            // Bonus 2
            Regex rgx = new Regex("[^a-zA-Z]");
            string alphaOnlyTextBlock = rgx.Replace(textBlock, "");

            Dictionary<string, int> charCounts = new Dictionary<string, int>();

            foreach (char i in alphaOnlyTextBlock)
            {
                string character = i.ToString();
                if (!charCounts.ContainsKey(character))
                {
                    charCounts.Add(character, 1);
                }
                else
                {
                    charCounts[character] += 1;
                }
            }

            foreach (KeyValuePair<string, int> count in charCounts)
            {
                Console.WriteLine(count.Key + ": " + count.Value);
            }
        }
    }
}
