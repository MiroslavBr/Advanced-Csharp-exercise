using System;

namespace _07.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[][] matrix = new long[int.Parse(Console.ReadLine())][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new long[row+1];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (col == 0 || col == matrix[row].Length-1)
                    {
                        matrix[row][col] = 1;
                    }
                    else
                    {
                        matrix[row][col] = matrix[row-1][col - 1] + matrix[row-1][col];
                    }
                }
                //Console.WriteLine(string.Join(" ", matrix[row]));
            }

            foreach (long[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));

            }
        }
    }
}
