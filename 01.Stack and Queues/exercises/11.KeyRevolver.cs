using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gubBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new(Console.ReadLine().Split().Select(int.Parse).ToArray());
            Stack<int> locks = new(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse());
            int valueOfIntelligence = int.Parse(Console.ReadLine());


            int countOfUsedBullets = 0;
            while (bullets.Count > 0 && locks.Count > 0)
            {

                int currentBullet = bullets.Peek();
                int currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop(); locks.Pop();
                    countOfUsedBullets++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    countOfUsedBullets++;
                }
                if (countOfUsedBullets % gubBarrelSize == 0&&bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                }


            }

            if (bullets.Count == 0 && locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${valueOfIntelligence - (bulletPrice * countOfUsedBullets)}");
            }

        }
    }
}
