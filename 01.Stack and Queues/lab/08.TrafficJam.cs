using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPassingCars = int.Parse(Console.ReadLine());

            Queue<string> carsInLine = new();
            int countOfpassedCars = 0;
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "green")
                {
                    for (int i = 1; i <= numberOfPassingCars && carsInLine.Count != 0; i++)
                    {
                        string passingCar = carsInLine.Dequeue();
                        Console.WriteLine($"{passingCar} passed!");
                        countOfpassedCars++;
                    }
                }
                else
                {
                    carsInLine.Enqueue(command);
                }
            }
            Console.WriteLine($"{countOfpassedCars} cars passed the crossroads.");
        }
    }
}
