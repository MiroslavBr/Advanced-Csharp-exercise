using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var numbers = Console.ReadLine().Split(", ").Select(int.Parse).Where(num=>num%2==0).OrderBy(num=>num).ToList();
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
