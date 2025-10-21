using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                int power = int.Parse(data[1]);
                int? displacement = null;
                string efficiency = null;

                if (data.Length == 3)
                {
                    if (int.TryParse(data[2],out _))
                    {
                        displacement = int.Parse(data[2]);
                    }
                    else
                    {
                        efficiency = data[2];
                    }
                }
                else if (data.Length == 4)
                {
                    displacement = int.Parse(data[2]);
                    efficiency = data[3];
                }

                Engine engine = new(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] data = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = data[0];
                string engineModel = data[1];
                int? weight = null;
                string color = null;

                if (data.Length == 3)
                {
                    if (int.TryParse(data[2], out _))
                    {
                        weight = int.Parse(data[2]);
                    }
                    else
                    {
                        color = data[2];
                    }
                }
                else if (data.Length == 4)
                {
                    weight = int.Parse(data[2]);
                    color = data[3];
                }
                Car car = new(model, engines.Find(eng => eng.Model == engineModel), weight, color);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}