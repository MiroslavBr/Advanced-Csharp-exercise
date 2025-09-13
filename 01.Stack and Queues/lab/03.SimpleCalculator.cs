using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Reverse().ToArray();

            Stack<string> expression = new(input);

            int sum = 0;
            string currentOperator = "+";

            while (expression.Count != 0)
            {
                if (expression.Peek() == "-" || expression.Peek() == "+")
                {
                    currentOperator = expression.Pop();
                }
                sum += int.Parse(currentOperator + expression.Pop());
            }

            Console.WriteLine(sum);
        }
    }
}
