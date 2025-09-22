using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfTheSets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> numbers1 = new();
            HashSet<int> numbers2 = new();

            ReadSet(numbers1, sizeOfTheSets[0]);
            ReadSet(numbers2, sizeOfTheSets[1]);

            Console.WriteLine(string.Join(" ", numbers1.Where(numbers2.Contains)));
            //PrintSameElements(sizeOfTheSets, numbers1, numbers2);
        }

        private static void PrintSameElements(int[] sizeOfTheSets, HashSet<int> numbers1, HashSet<int> numbers2)
        {
            HashSet<int> smallerSet = sizeOfTheSets[0] > sizeOfTheSets[1] ? numbers2 : numbers1;
            HashSet<int> biggerSet = sizeOfTheSets[0] > sizeOfTheSets[1] ? numbers1 : numbers2;
            foreach (int set in smallerSet)
            {
                if (biggerSet.Contains(set))
                {
                    Console.Write(set + " ");
                }
            }
        }

        static void ReadSet(HashSet<int> hashSet, int size)
        {
            for (int i = 0; i < size; i++)
            {
                hashSet.Add(int.Parse(Console.ReadLine()));
            }
        }
    }
}
