using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAnount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public string Model { get; set; }
        public double FuelAnount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive(double distance)
        {
            bool canDrive = this.FuelAnount - (this.FuelConsumptionPerKilometer * distance) >= 0;
            if (canDrive)
            {
                this.FuelAnount -= this.FuelConsumptionPerKilometer * distance;
                TravelledDistance += distance;
                return true;
            }
            return false;
        }
    }
}
