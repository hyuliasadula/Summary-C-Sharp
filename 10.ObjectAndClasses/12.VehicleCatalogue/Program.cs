using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.VehicleCatalogue
{
    /*
     Until you receive the "End" command, you will be receiving lines of input in the following format:
"{typeOfVehicle} {model} {color} {horsepower}"
When you receive the "End" command, you will start receiving information about some vehicles.

"Type: {typeOfVehicle}
Model: {modelOfVehicle}
Color: {colorOfVehicle} 
Horsepower: {horsepowerOfVehicle}"

When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the average horsepower of the trucks in the format:
"{typeOfVehicles} have average horsepower of {averageHorsepower}."
The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by the total count of all vehicles from that type. Format the answer to the second digit after the decimal point.
     
     Constraints
The type of vehicle will always be either a car or a truck.
You will not receive the same model twice.
The received horsepower will be an integer in the range [1…1000].
You will receive at most 50 vehicles.
The separator will always be single whitespace.
     
     

    Input 
truck Man red 200
truck Mercedes blue 300
car Ford green 120
car Ferrari red 550
car Lamborghini orange 570
End
Ferrari
Ford
Man
Close the Catalogue


    Output
    Type: Car
    Model: Ferrari
    Color: red
    Horsepower: 550
    Type: Car
    Model: Ford
    Color: green
    Horsepower: 120
    Type: Truck
    Model: Man
    Color: red
    Horsepower: 200
    Cars have average horsepower of: 413.33.
    Trucks have average horsepower of: 250.00.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] vehicles = input.Split(" ");
                string vehicleType = vehicles[0];
                string vehicleModel = vehicles[1];
                string vehicleColor = vehicles[2];
                int vehicleHorsePower = int.Parse(vehicles[3]);

                if (vehicleType == "car")
                {
                    Cars car = new Cars(vehicleModel, vehicleColor, vehicleHorsePower);
                    cars.Add(car);
                }
                else if (vehicleType == "truck")
                {
                    Trucks truck = new Trucks(vehicleModel, vehicleColor, vehicleHorsePower);
                    trucks.Add(truck);
                }
            }

            string modelInput;
            while ((modelInput = Console.ReadLine()) != "Close the Catalogue")
            {
                Cars car = cars.FirstOrDefault(c => c.Model == modelInput);
                Trucks truck = trucks.FirstOrDefault(t => t.Model == modelInput);

                if (car != null)
                {
                    car.PrintDetails();
                }
                else if (truck != null)
                {
                    truck.PrintDetails();
                }
            }

            double carAverageHorsePower = cars.Count > 0 ? cars.Average(c => c.HorsePower) : 0;
            double truckAverageHorsePower = trucks.Count > 0 ? trucks.Average(t => t.HorsePower) : 0;

            Console.WriteLine($"Cars have average horsepower of: {carAverageHorsePower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHorsePower:f2}.");
        }
    }
}
