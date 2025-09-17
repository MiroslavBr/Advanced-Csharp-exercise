using System;
using System.Linq;
using System.Numerics;

namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersOfRows = int.Parse(Console.ReadLine());

            int[][] jagged = new int[numbersOfRows][];
            for (int row = 0; row < numbersOfRows; row++)
            {
                jagged[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            AnakyzingJaggedArray(numbersOfRows, jagged);

            ManipulateJaggedArray(jagged);

            PrintJaggedArray(jagged);
        }

        private static void ManipulateJaggedArray(int[][] jagged)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandParts = command.Split(' ');
                string action = commandParts[0];

                if (!AreCoordinatesInt(commandParts))
                {
                    continue;
                }

                int x = int.Parse(commandParts[1]);
                int y = int.Parse(commandParts[2]);
                int number = int.Parse(commandParts[3]);

                if (!AreCoordinateValid(jagged, x, y))
                {
                    continue;
                }

                if (action == "Add")
                {
                    jagged[x][y] += number;
                }
                else if (action == "Subtract")
                {
                    jagged[x][y] -= number;
                }

            }
        }

        private static bool AreCoordinateValid(int[][] jagged, int x, int y)
        {
            if (!(x >= 0 && x < jagged.Length) ||
                !(y >= 0 && y < jagged[x].Length))
            {
                return false;
            }

            return true;
        }

        private static bool AreCoordinatesInt(string[] commandParts)
        {
            if (!int.TryParse(commandParts[1], out _) ||
                !int.TryParse(commandParts[2], out _))
            {
                return false;
            }

            return true;
        }

        private static void PrintJaggedArray(int[][] jagged)
        {
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static void AnakyzingJaggedArray(int numbersOfRows, int[][] jagged)
        {
            for (int row = 0; row < numbersOfRows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }
        }
    }
}
