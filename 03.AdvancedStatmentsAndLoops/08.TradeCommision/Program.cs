using System;

namespace _08.TradeCommision
{
    internal class Program
    {
        /*
         
         Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите:
            Град	0 ≤ s ≤ 500	   500 < s ≤ 1 000	   1 000 < s ≤ 10 000	   s > 10 000
            Sofia	   5%	                7%	              8%	              12%
            Varna	   4.5%	               7.5%	              10%	              13%
            Plovdiv 	5.5%	            8%	             12%	             14.5%
            Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (реално число) , въведени от потребителя, и изчислява и извежда размера на търговската комисионна според горната таблица. Резултатът да се изведе форматиран до 2 цифри след десетичната точка. При невалиден град или обем на продажбите (отрицателно число) да се отпечата "error". 
         */
        static void Main(string[] args)
        {
            Console.Write("City name: ");
            string cityName = Console.ReadLine();

            Console.WriteLine("Sales volume: ");
            double salesVolume = double.Parse(Console.ReadLine());
            double rate = 0;

            if (salesVolume >= 0 && salesVolume<= 500 )
            {
                switch (cityName)
                {
                    
                    case "Sofia":
                        rate = 0.05;
                        rate *= salesVolume;
                        break;
                    case "Varna":
                        rate = 0.045;
                        rate *= salesVolume;
                        break;
                    case "Plovdiv":
                        rate = 0.055;
                        rate *= salesVolume;
                        break;
                }
            }
            else if (salesVolume > 500 && salesVolume <= 1000)
            {
               
                switch (cityName)
                {

                    case "Sofia":
                        rate = 0.07;
                        rate *= salesVolume;
                        break;
                    case "Varna":
                        rate = 0.075;
                        rate *= salesVolume;
                        break;
                    case "Plovdiv":
                        rate = 0.08;
                        rate *= salesVolume;
                        break;
                }
            }
            else if (salesVolume > 1000 && salesVolume <= 10000)
            {
                
                switch (cityName)
                {

                    case "Sofia":
                        rate = 0.08;
                        rate *= salesVolume;
                        break;
                    case "Varna":
                        rate = 0.10;
                        rate *= salesVolume;
                        break;
                    case "Plovdiv":
                        rate = 0.12;
                        rate *= salesVolume;
                        break;
                }
            }
            else if (salesVolume > 10000)
            {
                
                switch (cityName)
                {

                    case "Sofia":
                        rate = 0.12;
                        rate *= salesVolume;
                        break;
                    case "Varna":
                        rate = 0.13;
                        rate *= salesVolume;
                        break;
                    case "Plovdiv":
                        rate = 0.145;
                        rate *= salesVolume;
                        break;
                }
            }
            if (cityName == "Sofia" || cityName == "Plovdiv" || cityName =="Varna")
            {
                Console.WriteLine($"{rate:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
