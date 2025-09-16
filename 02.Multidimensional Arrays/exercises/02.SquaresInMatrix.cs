using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];

            ReadMatrix(matrix);

            HowMany2By2WithEqualPrastHave(matrix);
        }

        private static void HowMany2By2WithEqualPrastHave(char[,] matrix)
        {
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char character = matrix[row, col];
                    int currentRow, currentCol;
                    bool isThereDifferentChar = false;
                    for (currentRow = row; currentRow < row + 2; currentRow++)
                    {
                        for (currentCol = col; currentCol < col + 2; currentCol++)
                        {
                            if (matrix[currentRow, currentCol] != character)
                            {
                                isThereDifferentChar = true;
                                break;
                            }
                        }
                        if (isThereDifferentChar) { break; }
                    }
                    if (!isThereDifferentChar)
                    {
                        count++;
                    }


                }
            }
            Console.WriteLine(count);
        }

        private static void ReadMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] numbersInRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersInRow[col];
                }
            }
        }
    }
}
