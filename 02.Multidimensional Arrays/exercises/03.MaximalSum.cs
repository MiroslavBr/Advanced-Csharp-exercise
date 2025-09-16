using System;
using System.Linq;

namespace _03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[size[0], size[1]];

            ReadMatrix(matrix);

            int[,] biggest3By3SubMatrix;
            int biggestSum;
            GetTheBiggest3By3MatrixAndHisSum(matrix, out biggest3By3SubMatrix, out biggestSum);

            PrintTheMatrixAndHisSum(biggest3By3SubMatrix, biggestSum);

        }

        private static void PrintTheMatrixAndHisSum(int[,] biggest3By3SubMatrix, int biggestSum)
        {
            Console.WriteLine($"Sum = {biggestSum}");
            for (int row = 0; row < biggest3By3SubMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < biggest3By3SubMatrix.GetLength(1); col++)
                {
                    Console.Write(biggest3By3SubMatrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void GetTheBiggest3By3MatrixAndHisSum(int[,] matrix, out int[,] biggest3By3SubMatrix, out int biggestSum)
        {
            biggest3By3SubMatrix = new int[3, 3];
            biggestSum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int[,] subMatrix = new int[3, 3];
                    int subSum = 0;
                    
                    for (int r = 0; r < 3; r++)
                    {
                        for (int c = 0; c < 3; c++)
                        {
                            subSum += matrix[row + r, col + c];
                            subMatrix[r, c] = matrix[row + r, col + c];
                        }
                    }

                    if (subSum > biggestSum)
                    {
                        biggestSum = subSum;
                        biggest3By3SubMatrix = subMatrix;
                    }

                    row -= 2;
                }
            }
        }

        private static void ReadMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbersInRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersInRow[col];
                }
            }
        }
    }
}