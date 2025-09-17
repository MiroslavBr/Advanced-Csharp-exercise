using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demention = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<char> snake = new(Console.ReadLine().ToCharArray());

            char[,] matrix = new char[demention[0], demention[1]];
            SnakeMovement(snake, matrix);

            PrintMatrix(matrix);
        }

        private static void SnakeMovement(Queue<char> snake, char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if ((row + 1) % 2 != 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snake.Dequeue();
                        snake.Enqueue(matrix[row, col]);
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake.Dequeue();
                        snake.Enqueue(matrix[row, col]);
                    }
                }

            }
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
