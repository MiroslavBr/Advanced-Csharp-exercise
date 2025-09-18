using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Channels;

namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new();

            string data =string.Empty;

            while ((data = Console.ReadLine()) != "END")
            {
                string[] dataParts = data.Split(", ");
                string command = dataParts[0];
                string carNumber = dataParts[1];


                if (command.ToLower() == "in")
                {
                    parkingLot.Add(carNumber);
                }
                else if (command.ToLower() == "out")
                {
                    parkingLot.Remove(carNumber);
                }
            }

            string output = (parkingLot.Count == 0)
                 ? "Parking Lot is Empty"
                 : string.Join(Environment.NewLine, parkingLot);
            Console.WriteLine(output);
            //if (parkingLot.Count == 0)
            //{
            //    Console.WriteLine("Parking Lot is Empty");
            //}else
            //{
            //    Console.WriteLine(string.Join(Environment.NewLine, parkingLot));
            //}
        }
    }
}
