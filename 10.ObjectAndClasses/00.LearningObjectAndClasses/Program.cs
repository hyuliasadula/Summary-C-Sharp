using System;

namespace _00.LearningObjectAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * This is how we create a new item(game1: name it however you want) and call the Game class
             we write our date inside of the() cause we defined them in the Game class otherwise
             Otherwise we should have written the code like 

            Game game1 = new Game();
            game1.title = "Super Mario";
            game1.studio = "Nintendo";
            game1.rating = 3.0;
            game1.year = 2000;
            Console.WriteLine(game1.title);
            */
            Game game1 = new Game("Super Mario", "Nintendo", 3.0, 2001);

            // Output the details of the game to the console
            Console.WriteLine("The title of the game is " + game1.Title +
                              ", the studio is " + game1.Studio +
                              ", my rating is " + game1.Rating +
                              " and it was created in " + game1.Year);


        }
    }
}
