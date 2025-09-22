using System;
using System.Collections.Generic;
using System.Linq;
namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> frequencyOfSymbols = new();
            foreach (char character in input)
            {
                if (!frequencyOfSymbols.ContainsKey(character))
                {
                    frequencyOfSymbols[character] = 0;
                }
                frequencyOfSymbols[character]++;
            }

            foreach (KeyValuePair<char, int> characterInfo in frequencyOfSymbols)
            {
                Console.WriteLine($"{characterInfo.Key}: {characterInfo.Value} time/s");
            }

        }
    }
}
