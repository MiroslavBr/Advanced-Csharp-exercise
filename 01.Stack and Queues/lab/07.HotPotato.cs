using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> kidsNames = new(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());

            while (kidsNames.Count > 1)
            {
                string currentKid = string.Empty;
                for (int i = 1; i <= n; i++)
                {
                    currentKid = kidsNames.Dequeue();
                    if (i != n)
                    {
                        kidsNames.Enqueue(currentKid);
                    }
                }
                Console.WriteLine($"Removed {currentKid}");
            }
            Console.WriteLine($"Last is {kidsNames.Dequeue()}");
        }
    }
}
