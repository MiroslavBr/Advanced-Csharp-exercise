using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();


            List<int> numbers = GetNumbers(range, command, num => num % 2 == 0);

            Console.WriteLine(string.Join(" ", numbers));
        }

        static List<int> GetNumbers(int[] range, string command, Predicate<int> isTheNumberEven)
        {
            List<int> numbers = new();
            for (int i = range[0]; i <= range[1]; i++)
            {
                switch (command)
                {
                    case "even":
                        if (isTheNumberEven(i)) numbers.Add(i);
                        break;
                    case "odd":
                        if (!isTheNumberEven(i)) numbers.Add(i);
                        break;
                }
            }
            return numbers;
        }
    }
}