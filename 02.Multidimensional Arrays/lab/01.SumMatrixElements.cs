using System;
using System.Linq;

namespace _00.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rowAndCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[rowAndCol[0], rowAndCol[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersInRow = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersInRow[col];
                }
            }

            Console.WriteLine($"{matrix.GetLength(0)}\n{matrix.GetLength(1)}");
            int sum = 0;
            foreach (int num in matrix)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
