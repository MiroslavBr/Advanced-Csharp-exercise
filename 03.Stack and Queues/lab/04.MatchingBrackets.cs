using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexOfOpenningBrackets = new();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    indexOfOpenningBrackets.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int startingIndex = indexOfOpenningBrackets.Pop();
                    Console.WriteLine(expression.Substring(startingIndex,i-startingIndex+1));
                }

            }
        }
    }
}
