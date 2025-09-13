using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowAndCol[0], rowAndCol[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersInRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersInRow[col];
                }
            }

            int[] sumOfAllColumns = new int[matrix.GetLength(1)];
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sumOfAllColumns[col] += matrix[row, col];
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine,sumOfAllColumns));
        }
    }
}
