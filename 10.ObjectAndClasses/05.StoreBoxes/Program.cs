using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.StoreBoxes
{
    internal class Program
    {
        /*
         Define a class Item, which contains these properties: Name and Price.
Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
The Price of one box has to be calculated: itemQuantity * itemPrice.
        Print all the boxes ordered descending by price for a box, in the following format:
{boxSerialNumber}
-- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}
-- ${boxPrice}
The price should be formatted to the 2nd digit after the decimal separator.

        Input 
19861519 Dove 15 2.50
86757035 Butter 7 3.20
39393891 Orbit 16 1.60
37741865 Samsung 10 1000
end 


       Output 
        37741865
        -- Samsung - $1000.00: 10
        -- $10000.00
        19861519
        -- Dove - $2.50: 15
        -- $37.50
        39393891
        -- Orbit - $1.60: 16
        -- $25.60
        86757035
        -- Butter - $3.20: 7
        -- $22.4
         
         */

        public class Item
        { 
            public string Name { get; set; }
            public decimal Price { get; set; }
        
        }
        
        public class Box 
        {
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemQuantity { get; set; }
            public decimal PriceForBox
            {
                get { return ItemQuantity * Item.Price; }
            }
        }
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string[] currentItem = Console.ReadLine().Split(' ').ToArray();
                if (currentItem[0].ToLower() == "end")
                {
                    break;
                }

                string serialNumber = currentItem[0];
                string itemName = currentItem[1];
                int itemQuantity = int.Parse(currentItem[2]);
                decimal itemPrice = decimal.Parse(currentItem[3]);

                //Item object
                Item newItem = new Item
                {
                    Name = itemName,
                    Price = itemPrice
                };

                //Box object
                Box newBox = new Box
                {
                    SerialNumber = serialNumber,
                    Item = newItem,
                    ItemQuantity = itemQuantity
                };

                boxes.Add(newBox);
            }

            

            // Sort boxes by the PriceForBox in descending order
            //box => box.PriceForBox is a lambda expression. It takes a Box object (referred to as box) and returns its PriceForBox property.
            List<Box> sortedBoxes = boxes.OrderByDescending(box => box.PriceForBox).ToList();


            foreach (Box box in sortedBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForBox:F2}");
            }

        }
    }
}
/*How the code above works - source ChatGPT
 *  
 // Bubble Sort: Manually sort the boxes by PriceForBox in descending order
for (int i = 0; i < boxes.Count - 1; i++)
{
    for (int j = 0; j < boxes.Count - i - 1; j++) 
    {
        if (boxes[j].PriceForBox < boxes[j + 1].PriceForBox)
        {
            // Swap boxes[j] and boxes[j + 1]
            Box temp = boxes[j];
            boxes[j] = boxes[j + 1];
            boxes[j + 1] = temp;
        }
    }
}

// Output the boxes
foreach (Box box in boxes)
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForBox:F2}");
}

 */