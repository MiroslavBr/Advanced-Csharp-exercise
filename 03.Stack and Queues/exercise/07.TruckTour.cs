using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _07.TruckTour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());

            Queue<PetrolPump> petrolPumpsRoute = new();
            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                PetrolPump petrolPump = new(Console.ReadLine().Split().Select(int.Parse).ToArray());

                petrolPumpsRoute.Enqueue(petrolPump);
            }


            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                int TruckFuel = 0;
                bool bestRoute = true;
                foreach (PetrolPump petrolPump in petrolPumpsRoute)
                {
                    TruckFuel += petrolPump.Petrol- petrolPump.DistanceToNextPump;
                    if (TruckFuel < 0)
                    {
                        bestRoute = false;
                        break;
                    }
                }

                if (bestRoute)
                {
                    Console.WriteLine(i);
                    break;
                }
                petrolPumpsRoute.Enqueue(petrolPumpsRoute.Dequeue());
            }
        }
    }


    public class PetrolPump
    {
        public PetrolPump(int[] info)
        {
            int petrol = info[0];
            int distance = info[1];

            Petrol = petrol;
            DistanceToNextPump = distance;
        }
        public PetrolPump(int petrol, int distance)
        {
            Petrol = petrol;
            DistanceToNextPump = distance;
        }
        public int Petrol { get; set; }
        public int DistanceToNextPump { get; set; }
    }
}

