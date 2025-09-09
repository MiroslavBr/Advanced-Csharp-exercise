using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new(Console.ReadLine().Split().Select(int.Parse).ToArray());

            Console.WriteLine(string.Join(", ", numbers.Where(x => x % 2 == 0)));

            //int count = numbers.Count();
            //for (int i = 0; i < count; i++)
            //{
            //    int num = numbers.Dequeue();
            //    if (num % 2 == 0)
            //    {
            //        if (i != count - 1)
            //        {
            //            Console.Write(num + ", ");
            //        }
            //        else
            //        {
            //            Console.Write(num);
            //        }

            //    }
            //}

            //while (numbers.Count() > 0)
            //{
            //    int num = numbers.Dequeue();
            //    if (num % 2 == 0)
            //    {
            //        if (numbers.Count > 1)
            //        {
            //            Console.Write(num + ", ");
            //        }
            //        else
            //        {
            //            Console.Write(num);
            //        }

            //    }
            //}
        }
    }
}
