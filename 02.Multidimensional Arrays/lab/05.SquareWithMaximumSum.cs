using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SquareWithMaximumSum
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

            Dictionary<int, int[,]> sumOfAMatrix = new();

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = 0;
                    int[,] currentmatrix = new int[2, 2];

                    
                    for (int startRow = 0,endRow = row; startRow < 2; startRow++,endRow++)
                    {
                        for (int startCol=0,endCol = col; startCol < 2; startCol++,endCol++)
                        {
                            currentmatrix[startRow, startCol] = matrix[endRow, endCol];
                            sum += matrix[endRow, endCol];
                        }
                    }

                    if (!sumOfAMatrix.ContainsKey(sum))
                    {
                        sumOfAMatrix.Add(sum, currentmatrix);
                    }
                }
            }



            int biggestSum = sumOfAMatrix.Max(x => x.Key);
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(sumOfAMatrix[biggestSum][row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(biggestSum);

        }
    }
}
