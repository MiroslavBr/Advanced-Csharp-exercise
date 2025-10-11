using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> predicate = num => num % divisor != 0;

            List<int> reverstNumbers = new();
            for (int i = numbers.Length-1; i >= 0; i--)
            {
                if (predicate(numbers[i]))
                {
                    reverstNumbers.Add(numbers[i]);
                }
            }

            Console.WriteLine(string.Join(" ", reverstNumbers));
        }
    }
}
