using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pushCount = input[0];
            int popCount = input[1];
            int numberX = input[2];

            Stack<int> stackOfNumbers = new(Console.ReadLine().Split().Select(int.Parse).ToArray());

            for (int i = 0; i < popCount; i++)
            {
                stackOfNumbers.Pop();
            }

            if (stackOfNumbers.Contains(numberX))
            {
                Console.WriteLine("true");
            }
            else
            {
                //int[] arr = stackOfNumbers.ToArray().Order().ToArray();
                //stackOfNumbers = new(arr);
                //Console.WriteLine(stackOfNumbers.Peek());

                Console.WriteLine(stackOfNumbers.Min());
            }


        }
    }
}
