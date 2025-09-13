using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SymbolinMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowAndCol = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rowAndCol, rowAndCol];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();  
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char specialChar = char.Parse(Console.ReadLine());
            bool found = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == specialChar)
                    {
                        Console.WriteLine($"({row}, {col})");
                        found = true;
                        return;
                    }
                }
                
            }

            if (!found)
            {
                Console.WriteLine($"{specialChar} does not occur in the matrix");
            }
        }
    }
}
