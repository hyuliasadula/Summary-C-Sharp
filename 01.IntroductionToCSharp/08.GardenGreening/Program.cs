using System;

namespace _08.GardenGreening
{
    internal class Program
    {
        /*
         
         Напишете програма, която изчислява необходимате сума, които Божидара ще трябва да заплати на фирмата изпълнител на проекта. Цената на един кв. м. е 7.61 лв със ДДС. Понеже нейният двор е доста голям, фирмата изпълнител предлага 18% отстъпка от крайната цена
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Meters: ");
            double cubikMeters = double.Parse(Console.ReadLine());
            double pricePerCubikMeter = 7.61;
            double discount = 0.18;

            double price = cubikMeters * pricePerCubikMeter;
            double discountPrice = price * discount;
            double finalPrice = price - discountPrice;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discountPrice} lv.");
        }
    }
}
