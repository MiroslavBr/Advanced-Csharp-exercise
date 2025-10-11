using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////One way
            //int num = int.Parse(Console.ReadLine());
            //string[] names = Console.ReadLine().Split();
            //foreach (string name in names)
            //{
            //    if (num <= name.Sum(ch => ch))
            //    {
            //        Console.WriteLine(name);
            //        break;
            //    }
            //}
            int num = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, int, bool> compareNameToNum = (name, num) => name.Sum(ch => ch) >= num;
            Func<string[], int, Func<string, int, bool>, string> find = (names, num, compareNameToNum)
                => names.FirstOrDefault(x => compareNameToNum(x, num));

            ////if u dont know the method FirstOrDefault
            //{
            //foreach (string name in names)
            //{
            //    if (compareNameToNum(name, num))
            //    {
            //        return name;
            //    }
            //}
            //return null;
            //};


            string name = find(names, num, compareNameToNum);
            Console.WriteLine(name);
        }
    }
}
