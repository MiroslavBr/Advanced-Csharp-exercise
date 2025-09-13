using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new(Console.ReadLine().Split().Select(int.Parse).ToArray());
            int capasityOfARack = int.Parse(Console.ReadLine());

            int countOfRacks = 1;
            int sum = 0;
            while (clothes.Count > 0)
            {
                if (sum + clothes.Peek() <= capasityOfARack)
                {
                    sum += clothes.Pop();
                }
                else
                {
                    countOfRacks++;
                    sum = 0;
                }
            }
            Console.WriteLine(countOfRacks);

        }
    }
}
