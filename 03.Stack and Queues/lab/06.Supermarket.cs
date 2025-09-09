using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customersInLine = new();

            string input =string.Empty; 
            while ((input= Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine,customersInLine));
                    customersInLine.Clear();
                }
                else
                {
                    customersInLine.Enqueue(input);
                }
            }

            Console.WriteLine($"{customersInLine.Count} people remaining.");

        }
    }
}
