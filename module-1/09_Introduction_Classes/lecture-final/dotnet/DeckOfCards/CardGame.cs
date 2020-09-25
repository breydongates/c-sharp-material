using System;
using System.Collections.Generic;
using DeckOfCards.PlayingCards;

namespace DeckOfCards
{
    /// <summary>
    /// Responsible for managing a game of cards
    /// </summary>
    public class CardGame
    {
        /// <summary>
        /// Prompts the user for actions and responds to those actions until the game ends.
        /// </summary>
        public void Play()
        {
            // 1. Create a list to store cards
            List<Card> cards = new List<Card>();

            bool keepGoing = true;
            while (keepGoing)
            {
                // Clear the screen from last time around
                Console.Clear();

                // Ask the user what they want to do
                Console.WriteLine("What do you want to do? ");
                Console.WriteLine("1. Create a new card.");
                Console.WriteLine("2. Display all of the cards.");
                Console.WriteLine("3. Flip all of the cards.");
                Console.WriteLine("Q. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        // Get the value for the new card
                        Console.Write("What is the value of the card (1-13): ");
                        int value = int.Parse(Console.ReadLine());

                        // Get the suit for the new card
                        Console.Write("What suit does the card have (Hearts, Diamonds, Clubs, Spades): ");
                        string suit = Console.ReadLine();

                        // Is the card face up or face down
                        Console.Write("Is the card face up (True/False): ");
                        bool isFaceUp = bool.Parse(Console.ReadLine());

                        // 3. Instantiate a new Card instance
                        Card playingCard = new Card(isFaceUp);
                        playingCard.Value = value;
                        playingCard.Suit = suit;
                        // playingCard.IsFaceUp = isFaceUp;
                        //playingCard.DisplayText = "I'm Batman";

                        // 4. Add the card object to the list of cards
                        cards.Add(playingCard);

                        break;

                    case "2":
                        Console.WriteLine("Displaying all of the cards.");

                        foreach (Card card in cards)
                        {
                            Console.WriteLine(card.DisplayText);
                        }

                        // 5. Make a DisplayText property on Card
                        // 6. Get the value from card.DisplayText and display it
                        break;

                    case "3":
                        Console.WriteLine($"Flipping the cards.");

                        foreach (Card card in cards)
                        {
                            bool isNowFaceUp = card.Flip();

                            Console.WriteLine("You turn a card so that face up = " + isNowFaceUp);

                            card.WeCanPassParametersToMethods(5, 1);
                            //card.IsFaceUp = !card.IsFaceUp;
                        }
                        // 7a. Set IsFaceUp Directly                        
                        // 7b. Make IsFaceUp have a private setter
                        // 7c. Add a Flip method on Card, then call it here
                        break;

                    case "Q":
                        Console.WriteLine("Thank you for playing! Press any key to end the application.");

                        keepGoing = false;
                        break;
                }

                // Wait for user to press a key to acknowledge the result
                Console.ReadKey();
            }
        }
    }
}
