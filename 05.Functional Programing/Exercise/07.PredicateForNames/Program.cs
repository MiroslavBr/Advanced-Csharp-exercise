using System;

namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtFilter = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Predicate<string> predicate = name => name.Length <= lenghtFilter;

            foreach (string name in names)
            {
                if (predicate(name))
                {
                    Console.WriteLine(name);
                }
            }

            //Action<int, string> printRightName = (lenght, name) =>
            //{
            //    if(name.Length<=lenght) Console.WriteLine(name);
            //};

            //foreach (string name in names)
            //{
            //    printRightName(lenghtFilter,name);
            //}
        }
    }
}
