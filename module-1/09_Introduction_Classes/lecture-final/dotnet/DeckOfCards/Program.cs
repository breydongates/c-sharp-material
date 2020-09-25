using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main()
        {
            // 1. Create a new instance of card game
            CardGame game = new CardGame();

            // 2. Call the Play method on card game
            game.Play();

            Console.WriteLine("That's all folks");
        }
    }
}
