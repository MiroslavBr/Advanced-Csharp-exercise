using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] numsOnRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = numsOnRow[col];
                }
            }

            int primaryDiagonalSum = 0, secondaryDiagonalSum = 0;
            for (int row = 0, col = size - 1; row < size; row++, col--)
            {
                primaryDiagonalSum += matrix[row, row];
                secondaryDiagonalSum += matrix[row, col];

            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }


    }
}
