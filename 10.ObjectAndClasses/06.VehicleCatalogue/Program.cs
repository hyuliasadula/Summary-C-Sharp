using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    internal class Program
    {
        /*
         Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
        Define a class Truck with the following properties: Brand, Model, and Weight.
        Define a class Car with the following properties: Brand, Model, and Horse Power.
        Define a class Catalog with the following properties: Collections of Trucks and Cars.
        You must read the input, until you receive the "end" command. It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
        In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:

        "Cars:
        {Brand}: {Model} - {Horse Power}hp

        Trucks:
        {Brand}: {Model} - {Weight}kg"
         

        Input 

Car/Audi/A3/110
Car/Maserati/Levante/350
Truck/Mercedes/Actros/9019
Car/Porsche/Panamera/375
end 
        
        Output
        Cars:
        Audi: A3 - 110hp
        Maserati: Levante - 350hp
        Porsche: Panamera - 375hp
        Trucks:
        Mercedes: Actros - 9019kg
         */
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "end")
                {
                    break;
                }

                string[] currentVehicle = input.Split('/');

                if (currentVehicle[0] == "Car")
                {
                    string brand = currentVehicle[1];
                    string model = currentVehicle[2];
                    string horsePower = currentVehicle[3];

                    // new Car object with the extracted details
                    Car car = new Car(brand, model, horsePower);

                    // To add the Car object to the cars list
                    cars.Add(car);
                }
                else if (currentVehicle[0] == "Truck")
                {
                    string brand = currentVehicle[1];
                    string model = currentVehicle[2];
                    string weight = currentVehicle[3];

                    Truck truck = new Truck(brand, model, weight);

                    trucks.Add(truck);
                }
            }
             
            //Catalog object with the lists of cars and trucks
            Catalog catalog = new Catalog(cars, trucks);

            // Calling the method to print the catalog information
            catalog.PrintVehicles();
        }
    }
}
