using System;
using System.Linq;

namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine().Split(", ").Select(decimal.Parse).ToArray();
            Func<decimal, decimal> calculatingVAT = x => x * 0.2m + x;
            foreach (decimal price in prices)
            { 
                Console.WriteLine(calculatingVAT(price).ToString("f2"));
            }


            ////one line solution 
            //Console.ReadLine()
            //    .Split(", ")
            //    .Select(decimal.Parse)
            //    .Select(x => x * 1.2m)
            //    .Select(x => x.ToString("f2"))
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x));
        }
    }
}
