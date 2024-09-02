using System;
using System.Collections.Generic;
using System.Text;

namespace _12.VehicleCatalogue
{
    internal class Cars
    {

        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public Cars(string model, string color, int horsePower)
        {
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Type: Car");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Horsepower: {HorsePower}");
        }
    }
}
