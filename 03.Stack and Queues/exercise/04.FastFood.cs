using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodLeft = int.Parse(Console.ReadLine());

            Queue<int> ordersQuantity = new(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Console.WriteLine(ordersQuantity.Max());
            while (ordersQuantity.Count > 0)
            {
                if (foodLeft >= ordersQuantity.Peek())
                {
                    foodLeft -= ordersQuantity.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (ordersQuantity.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(" ",ordersQuantity)}");
            }else
            {
                Console.WriteLine("Orders complete");
            }


        }
    }
}
