using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[int.Parse(Console.ReadLine())][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                if (row >= jaggedArray.Length|| row<0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (col >= jaggedArray[row].Length || col<0)
                    {
                        Console.WriteLine("Invalid coordinates");

                    }
                    else
                    {
                        if (command[0] == "Add")
                        {
                            jaggedArray[row][col] += value;

                        }
                        else if (command[0] == "Subtract")
                        {
                            jaggedArray[row][col] -= value;

                        }
                    }
                }
                    command = Console.ReadLine().Split();
            }

            foreach (int[] row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
