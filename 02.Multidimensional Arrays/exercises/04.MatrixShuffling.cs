using System;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[,] matrix = new string[demensions[0], demensions[1]];

            ReadMatrix(matrix);

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandParts = command.Split(' ');
                string action = commandParts[0];

                if (!IsCommandValid(commandParts, action))
                {
                    continue;
                }

                int[] coordinatesOfElementOne = { int.Parse(commandParts[1]), int.Parse(commandParts[2]) };
                int[] coordinatesOfElementTwo = { int.Parse(commandParts[3]), int.Parse(commandParts[4]) };

                if (!AreCoordinatesValid(coordinatesOfElementOne, demensions) ||
                    !AreCoordinatesValid(coordinatesOfElementTwo, demensions))
                {
                    
                    continue;
                }

                SwapElements(matrix, coordinatesOfElementOne, coordinatesOfElementTwo);
                PrintMatrix(matrix);
            }

        }

        private static bool IsCommandValid(string[] commandParts, string action)
        {
            if (action != "swap")
            {
                Console.WriteLine("Invalid input!");
                return false;
            }


            if (commandParts.Length != 5)
            {
                Console.WriteLine("Invalid input!");
                return false;
            }

            return true;
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SwapElements(string[,] matrix, int[] coordinatesOfElementOne, int[] coordinatesOfElementTwo)
        {
            string numberHolder = matrix[coordinatesOfElementOne[0], coordinatesOfElementOne[1]];
            matrix[coordinatesOfElementOne[0], coordinatesOfElementOne[1]] = matrix[coordinatesOfElementTwo[0], coordinatesOfElementTwo[1]];
            matrix[coordinatesOfElementTwo[0], coordinatesOfElementTwo[1]] = numberHolder;
        }

        static bool AreCoordinatesValid(int[] coordinatesOfElemet, int[] demensions)
        {
            int x = coordinatesOfElemet[0];
            int y = coordinatesOfElemet[1];
            int MaxValueForX = demensions[0];
            int MaxValueForY = demensions[1];
            if (x < MaxValueForX && y < MaxValueForY&& x >= 0 && y >= 0)
            {
                return true;
            }
            Console.WriteLine("Invalid input!");
            return false;

        }

        static void ReadMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numbersInRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbersInRow[col];
                }
            }
        }
    }
}
