using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.CardsGame
{
    internal class Program
    {
        /*
         You will be given two hands of cards, which will be represented by integers. 
        Assume each one is held by a different player. You have to find which one has the winning deck. 
        You start from the beginning of both hands of cards. 
        Compare the cards from the first deck to the cards from the second deck.
        The player, who holds the more powerful card on the current iteration, takes both cards and puts them at the back of his hand - the second player's card is placed last and the first person's card (the winning one) comes after it (second to last). If both players' cards have the same values - no one wins and the two cards must be removed from both hands. The game is over only when one of the decks is left without any cards. You have to display the result on the console and the sum of the remaining cards: "{First/Second} player wins! Sum: {sum}".

                Examples

            Input                           Output

            20 30 40 50
            10 20 30 40                 First player wins! Sum: 240

            10 20 30 40 50
            50 40 30 30 10              Second player wins! Sum: 50
         
         */
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            DetermineWinner(firstDeck, secondDeck);
        }

        static void DetermineWinner(List<int> firstDeck, List<int> secondDeck)
        {

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstPlayer = firstDeck[0];
                int secondPlayer = secondDeck[0];

                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);

                if (firstPlayer > secondPlayer)
                {
                    firstDeck.Add(firstPlayer);
                    firstDeck.Add(secondPlayer);
                }
                else if (secondPlayer > firstPlayer)
                {
                    secondDeck.Add(secondPlayer);
                    secondDeck.Add(firstPlayer);
                }


            }
            if (firstDeck.Count == 0)
            {
                int sum = 0;
                for (int i = 0; i < secondDeck.Count; i++)
                {
                    int numbers = secondDeck[i];
                    sum += numbers;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < firstDeck.Count; i++)
                {
                    int numbers = firstDeck[i];
                    sum += numbers;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
        }
    }
}
