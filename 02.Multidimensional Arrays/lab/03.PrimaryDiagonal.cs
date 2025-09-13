using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowAndCol = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowAndCol, rowAndCol];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersInRow = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersInRow[col];
                    if (row == col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
