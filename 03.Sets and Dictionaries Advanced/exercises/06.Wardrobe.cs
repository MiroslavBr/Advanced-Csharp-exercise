using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfData = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new();

            for (int i = 0; i < countOfData; i++)
            {
                string[] dataParts = Console.ReadLine().Split(" -> ");
                string color = dataParts[0];
                string[] clothes = dataParts[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new();
                }

                foreach (string clothe in clothes)
                {
                    if (!wardrobe[color].ContainsKey(clothe))
                    {
                        wardrobe[color][clothe] = 0;
                    }
                    wardrobe[color][clothe]++;

                }

            }

            string[] item = Console.ReadLine().Split();

            foreach ((string colors,Dictionary<string,int> clothes) in wardrobe)
            {
                Console.WriteLine($"{colors} clothes:");
                foreach ((string clothe, int count) in clothes)
                {
                    if (colors != item[0] || clothe != item[1])
                    {
                        Console.WriteLine($"* {clothe} - {count}");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe} - {count} (found!)");
                    }
                }
            }
        }
    }
}
