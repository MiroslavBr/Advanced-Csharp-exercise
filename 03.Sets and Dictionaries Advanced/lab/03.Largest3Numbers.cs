using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).ToList();

            //for (int i = 0; i < numbers.Count && i < 3; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x=>x).Take(3).ToList();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
