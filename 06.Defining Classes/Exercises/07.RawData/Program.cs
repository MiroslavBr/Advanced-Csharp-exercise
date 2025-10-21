using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
                
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] data = Console.ReadLine().Split();

                Car car = new(model: data[0]
                    , speed: int.Parse(data[1]), power: int.Parse(data[2])
                   , weight: int.Parse(data[3]), type: data[4]
                   , double.Parse(data[5]), int.Parse(data[6])
                   , double.Parse(data[7]), int.Parse(data[8])
                   , double.Parse(data[9]), int.Parse(data[10])
                   , double.Parse(data[11]), int.Parse(data[12]));

                cars.Add(car);
            }

            string typeOfCargo = Console.ReadLine();
            if (typeOfCargo == "fragile")
            {
                foreach (Car car in cars.Where(car => car.Cargo.Type == typeOfCargo
                && car.Tires.Any(tire=>tire.Pressure<1)))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            else
            {
                foreach (Car car in cars.Where(car => car.Cargo.Type == typeOfCargo
                && car.Engine.Power>250))
                {
                    Console.WriteLine($"{car.Model}");
                }
            }
            
        }
    }
}
