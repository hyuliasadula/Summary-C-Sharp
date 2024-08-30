using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }

        public Car(string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }
    }
}
