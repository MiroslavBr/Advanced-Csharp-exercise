using System;
using System.Collections.Generic;



namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            Dictionary<string, Car> carsByModels = new();
            ReadCardsInfo(carsCount, carsByModels);

            Drive(carsByModels);

            ShowCars(carsByModels);
        }

        private static void ReadCardsInfo(int carsCount, Dictionary<string, Car> carsByModels)
        {
            for (int i = 0; i < carsCount; i++)
            {
                string[] dataParts = Console.ReadLine().Split();
                Car car = new(dataParts[0],
                    double.Parse(dataParts[1]),
                     double.Parse(dataParts[2]));

                if (!carsByModels.ContainsKey(car.Model))
                {
                    carsByModels[car.Model] = car;
                }
            }
        }

        private static void Drive(Dictionary<string, Car> carsByModels)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandParts = command.Split(" ");
                if (!carsByModels[commandParts[1]].Drive(double.Parse(commandParts[2])))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
        }

        private static void ShowCars(Dictionary<string, Car> carsByModels)
        {
            foreach (Car car in carsByModels.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAnount:f2} {car.TravelledDistance}");
            }
        }
    }
}
