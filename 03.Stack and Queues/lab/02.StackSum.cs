using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> stackOfNumbers = new(inputOfNumbers);

            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "add":
                        int firstNumber = int.Parse(command[1]);
                        int secondNumber = int.Parse(command[2]);

                        stackOfNumbers.Push(firstNumber);
                        stackOfNumbers.Push(secondNumber);
                        break;

                    case "remove":
                        int count = int.Parse(command[1]);

                        if (count == stackOfNumbers.Count)
                        {
                            stackOfNumbers.Clear();
                        }
                        else if (count < stackOfNumbers.Count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                stackOfNumbers.Pop();
                            }
                        }
                        break;


                }

                command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => x.ToLower()).ToArray();

            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}
