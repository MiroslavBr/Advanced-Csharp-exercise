using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> letters = new();

            foreach (char c in input)
            {
                letters.Push(c);
            }

            //for (int i = 0; i < input.Length; i++)
            //{
            //    letters.Push(input[i]);
            //}

            foreach (char c in letters)
            {
                Console.Write(c);
            }

            //int stackLenght = letters.Count;
            //for (int i = 0; i < stackLenght; i++)
            //{
            //    Console.Write(letters.Pop());
            //}

            //while (letters.Count > 0)
            //{
            //    Console.Write(letters.Pop());
            //}
        }
    }
}
