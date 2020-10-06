using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class UserInterface
    {
        private readonly QuestionManager manager = new QuestionManager();

        public void RunInterface()
        {
            bool done = false;
            while (!done)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Sally the Squirrel's One-Stop Interview Question Shop!");
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.WriteLine();
                Console.WriteLine("1) Answer a Random Interview Question");
                Console.WriteLine("2) Save Scores");
                Console.WriteLine("3) Exit");
                Console.WriteLine();

                // TODO: Get a value from the user and respond appropriately
                Console.ReadLine();
            }

            Console.WriteLine("Thank you for coming to Sally's for all your interview question needs");
        }
    }
}
