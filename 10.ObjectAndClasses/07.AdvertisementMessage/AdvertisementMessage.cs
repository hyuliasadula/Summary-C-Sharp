using System;
using System.Collections.Generic;
using System.Text;

namespace _07.AdvertisementMessage
{
    internal class AdvertisementMessage
    { 
        private string[] phrases = {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can't live without this product."
        };

        private string[] events = {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        private string[] authors = {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

        private string[] cities = {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        // Random instance to select random elements
        private Random random = new Random();

        // Method to generate and print random advertisement messages
        public void GenerateMessages(int numberOfMessages)
        {
            for (int i = 0; i < numberOfMessages; i++)
            {
                string randomPhrase = phrases[random.Next(phrases.Length)];
                string randomEvent = events[random.Next(events.Length)];
                string randomAuthor = authors[random.Next(authors.Length)];
                string randomCity = cities[random.Next(cities.Length)];

                // Create the message and print it
                string message = $"{randomPhrase} {randomEvent} {randomAuthor} – {randomCity}.";
                Console.WriteLine(message);
            }
        }
    }
}