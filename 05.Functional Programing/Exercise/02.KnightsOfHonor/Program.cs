using System;

namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> format = name => Console.WriteLine($"Sir {name}");
            PrintFormated(names, format);
        }
        static void PrintFormated(string[] names , Action<string> format)
        {
            foreach (string name in names)
            {
                format(name);
            }
        }
    }
}
