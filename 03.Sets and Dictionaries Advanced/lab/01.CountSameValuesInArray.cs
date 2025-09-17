using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            Dictionary<double, int> occurrencesOfNumbers =  new();

            foreach (double number in numbers)
            {
                if (!occurrencesOfNumbers.ContainsKey(number))
                {
                    occurrencesOfNumbers[number]=0;
                }
                occurrencesOfNumbers[number]++;
            }

            foreach (KeyValuePair<double,int> number in occurrencesOfNumbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
