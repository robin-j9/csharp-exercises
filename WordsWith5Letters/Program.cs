using System;
using System.Collections.Generic;

namespace WordsWith5Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "banana", "kiwi", "melon" };
            list<string> wordlist = new list<string>(words);
            Print5LetterWords(wordList);
        }

        static void Print5LetterWords(List<string> wordList)
        {
            foreach (string word in wordList)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
