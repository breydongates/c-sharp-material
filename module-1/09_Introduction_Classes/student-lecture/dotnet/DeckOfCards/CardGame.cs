using System;

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

                        // 2. Define a Card class in another file
                        // 8. Use a custom constructor

                        // 3. Instantiate a new Card instance

                        // 4. Add the card object to the list of cards

                        break;

                    case "2":
                        Console.WriteLine("Displaying all of the cards.");

                        // 5. Make a DisplayText property on Card
                        // 6. Get the value from card.DisplayText and display it
                        break;

                    case "3":
                        Console.WriteLine($"Flipping the cards.");
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
