using System;
using System.Collections.Generic;

namespace SolarPowerEngineering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter words which are separated by space. Press Enter when done:");
            var inputWords = Console.ReadLine().Split(' ');

            var filteredWords = StringFilter.FilterWordsStartingWithA(inputWords);

            Console.WriteLine("Words which starts with 'A':");
            foreach (var word in filteredWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
