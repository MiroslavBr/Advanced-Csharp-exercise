using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int min = Aggregate(nums, int.MaxValue, (a, b) => Math.Min(a, b));
            Console.WriteLine(min);
        }
        static int Aggregate(int[] nums, int initialValue, Func<int, int, int> fnc)
        {
            int result = initialValue;
            foreach (int num in nums)
            {
                result = fnc(result, num);
            }
            return result;
        }

        /*
        static void Main(string[] args)
        {
            //Console.WriteLine(
            //    Console.ReadLine()
            //    .Split()
            //    .Select(int.Parse)
            //     .Min());

            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> comparator = 
                (previous, current) => previous > current;

            Console.WriteLine(PrintSmallestNumber(nums,comparator));
        }

        static int  PrintSmallestNumber(int[] nums, Func<int, int, bool> comparator)
        {
            int smallestNum = nums[0];
            foreach (int num in nums)
            {
                if (comparator(smallestNum, num))
                {
                    smallestNum= num;
                }
            }

            return smallestNum;
        }
        */
    }
}
