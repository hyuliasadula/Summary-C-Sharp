using System;
using System.Collections.Generic;
using System.Text;

namespace _00.LearningObjectAndClasses
{
    internal class Game
    {
        // Properties of the Game class
        public string Title { get; set; }
        public string Studio { get; set; }
        public double Rating { get; set; }
        public int Year { get; set; }

        // Constructor to initialize the properties
        // we can name it whatever we want just not the original     ex:title, studio...
        public Game(string title, string studio, double rating, int year)
        {
            Title = title;
            Studio = studio;
            Rating = rating;
            Year = year;
        }
    }
}
