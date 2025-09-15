using System;
using System.Collections.Generic;

namespace _010.Crossroads
{

    internal class Program
    {
        static public int CountOfPassedCars { get; set; }
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());

            Queue<string> crossRoad = new();



            string input = Console.ReadLine();
            while (input != "END")
            {
                if (input != "green")
                {
                    AddCarToTheQueue(crossRoad, input);
                }
                else
                {
                    if (!ObserveCarMovement(crossRoad, greenLightDuration, freeWindowDuration))
                    {
                        return;
                    }
                }
                input = Console.ReadLine();
            }
            PrintCountOfPassedCars();
        }

         static void PrintCountOfPassedCars()
        {
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{CountOfPassedCars} total cars passed the crossroads.");
        }

        static bool ObserveCarMovement(Queue<string> crossRoad, int greenLightDuration, int freeWindowDuration)
        {
            while (greenLightDuration > 0 && crossRoad.Count > 0)
            {
                string car = crossRoad.Peek();
                if (greenLightDuration - car.Length >= 0)
                {

                    greenLightDuration = DecreaseGreenTime(greenLightDuration, car.Length);
                    RemovePassedCarFromTheCrossroad(crossRoad);
                    continue;
                }
                else
                {
                    if ((greenLightDuration + freeWindowDuration - car.Length) < 0)
                    {
                        CarHadCrashed(greenLightDuration, freeWindowDuration, car);
                        return false;
                    }
                    else
                    {
                        RemovePassedCarFromTheCrossroad(crossRoad);
                        break;
                    }
                }
            }
            return true;
        }

         static void CarHadCrashed(int greenLightDuration, int freeWindowDuration, string car)
        {
            char hitIndex = char.Parse(car.Substring(greenLightDuration + freeWindowDuration, 1));
            Console.WriteLine("A crash happened!");
            Console.WriteLine($"{car} was hit at {hitIndex}.");
        }

        static int DecreaseGreenTime(int greenLightDuration, int carLength)
        {
            return greenLightDuration - carLength;
        }
         static void RemovePassedCarFromTheCrossroad(Queue<string> crossRoad)
        {
            crossRoad.Dequeue(); CountOfPassedCars++;
        }

        static void AddCarToTheQueue(Queue<string> crossRoad, string input)
        {
            crossRoad.Enqueue(input);
        }


    }
}
