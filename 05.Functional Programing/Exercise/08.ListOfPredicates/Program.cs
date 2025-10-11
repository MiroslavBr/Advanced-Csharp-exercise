using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            HashSet<int> set = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

            Func<int, int, bool> func = (num, devider) => num % devider == 0;
            List<int> list = new List<int>();
            for (int i = 1; i <= range; i++)
            {
                bool devisible = true;
                foreach (int devider in set)
                {
                    if (!func(i, devider))
                    {
                        devisible = false;
                        break;
                    }
                }
                if (devisible)
                    list.Add(i);
            }
            Console.WriteLine(string.Join(" ", list));
            
        }
    }
}
