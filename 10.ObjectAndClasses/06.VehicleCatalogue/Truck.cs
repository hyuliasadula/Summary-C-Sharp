﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    internal class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }
    }
}
