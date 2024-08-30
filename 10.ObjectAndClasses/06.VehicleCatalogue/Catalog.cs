using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    internal class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }


        // Constructor to initialize the Catalog with lists of cars and trucks
        public Catalog(List<Car> cars, List<Truck> trucks)
        {
            Cars = cars;
            Trucks = trucks;
        }

        public void PrintVehicles()
        {
            // Check if there are any cars in the catalog
            if (Cars.Any())
            {
                Console.WriteLine("Cars:");

                // Sort the cars list by brand name in ascending order and print each car
                foreach (var car in Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (Trucks.Any())
            {
                Console.WriteLine("Trucks:");

                // Sort the trucks list by brand name in ascending order and print each truck
                foreach (var truck in Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}