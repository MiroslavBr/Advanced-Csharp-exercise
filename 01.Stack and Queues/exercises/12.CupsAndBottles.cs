using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12.CupsAndBottles
{
    internal class Program
    {
        static int wastedLittersOfWater { get; set; }
        static void Main(string[] args)
        {
            Stack<int> cupsCapacity = new(Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse());
            Stack<int> waterBottles = new(Console.ReadLine().Split().Select(int.Parse).ToArray());

            //int wastedLittersOfWater = 0;
            while (cupsCapacity.Count > 0 && waterBottles.Count > 0)
            {
                CupToWatterBottleRatioCheker(cupsCapacity, waterBottles );
            }

            PrintOutput(cupsCapacity, waterBottles );
        }

        private static void PrintOutput(Stack<int> cupsCapacity, Stack<int> waterBottles)
        {
            if (cupsCapacity.Count > 0)
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsCapacity)}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", waterBottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedLittersOfWater}");
        }

        static void CupToWatterBottleRatioCheker(Stack<int> cupsCapacity, Stack<int> waterBottles)
        {
            int currentCupCapacity = cupsCapacity.Peek();
            int currentWaterBotlle = waterBottles.Peek();

            if (currentCupCapacity >= currentWaterBotlle)
            {
                currentCupCapacity = PoringIntoBiggerCup(cupsCapacity, waterBottles, currentCupCapacity, currentWaterBotlle);
            }
            else
            {
                wastedLittersOfWater = PoringIntoSmallerCup(cupsCapacity, waterBottles, wastedLittersOfWater, currentCupCapacity, currentWaterBotlle);
            }
        }

        private static int PoringIntoSmallerCup(Stack<int> cupsCapacity, Stack<int> waterBottles, int wastedLittersOfWater, int currentCupCapacity, int currentWaterBotlle)
        {
            waterBottles.Pop();
            cupsCapacity.Pop();
            wastedLittersOfWater += currentWaterBotlle - currentCupCapacity;
            return wastedLittersOfWater;
        }

        private static int PoringIntoBiggerCup(Stack<int> cupsCapacity, Stack<int> waterBottles, int currentCupCapacity, int currentWaterBotlle)
        {
            waterBottles.Pop();
            currentCupCapacity -= currentWaterBotlle;
            if (currentCupCapacity == 0)
            {
                cupsCapacity.Pop();
            }
            else
            {
                cupsCapacity.Pop();
                cupsCapacity.Push(currentCupCapacity);
            }

            return currentCupCapacity;
        }
    }
}
