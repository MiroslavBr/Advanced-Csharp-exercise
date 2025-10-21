using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine, int? weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int? Weight { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            string engineDisplacement = Engine.Displacement == null ? "n/a" : Engine.Displacement.ToString();
            string engineEfficiency = Engine.Efficiency == null ? "n/a" : Engine.Efficiency;
            string carWeight = Weight == null ? "n/a" : Weight.ToString();
            string carColor = Color == null ? "n/a" : Color;

            string output = $"{Model}:\r\n" +
                $"  {Engine.Model}:\r\n" +
                $"    Power: {Engine.Power}\r\n" +
                $"    Displacement: {engineDisplacement}\r\n" +
                $"    Efficiency: {engineEfficiency}\r\n" +
                $"  Weight: {carWeight}\r\n" +
                $"  Color: {carColor}";

            return output;

        }
    }
}
