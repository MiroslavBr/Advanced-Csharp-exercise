using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        Modify(numbers, num => num + 1);
                        break;
                    case "multiply":
                        Modify(numbers, num => num * 2);

                        break;
                    case "subtract":
                        Modify(numbers, num => num - 1);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                }
            }

        }

        static void Modify(int[] nums, Func<int, int> func)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = func(nums[i]);
            }
        }
    }
}