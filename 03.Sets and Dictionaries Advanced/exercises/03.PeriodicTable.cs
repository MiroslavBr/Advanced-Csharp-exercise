using System;
using System.Collections.Generic;

namespace _03.PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new();
            for (int i = 0; i < numberOfLines; i++)
            {
                string[] data = Console.ReadLine().Split();
                foreach (string partData in data)
                {
                    elements.Add(partData);
                }
            }

            Console.WriteLine(string.Join(" ",elements));
        }
    }
}
