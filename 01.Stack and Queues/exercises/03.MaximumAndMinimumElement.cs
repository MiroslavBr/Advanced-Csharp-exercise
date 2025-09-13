using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Stack<int> stackOfNumbers = new();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                if (command[0] == '1')
                {
                    string[] breakDownOfComand = command.Split();
                    int numberToPush = int.Parse(breakDownOfComand[1]);
                    stackOfNumbers.Push(numberToPush);
                }
                else if (command == "2")
                {
                    stackOfNumbers.Pop();
                }
                else if (command == "3" && stackOfNumbers.Count != 0)
                {
                    Console.WriteLine(stackOfNumbers.Max());
                }
                else if (command == "4" && stackOfNumbers.Count != 0)
                {
                    Console.WriteLine(stackOfNumbers.Min());
                }
            }

            Console.WriteLine(string.Join(", ", stackOfNumbers));
        }
    }
}
