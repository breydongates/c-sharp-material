using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    /// <summary>
    /// This class is responsible for displaying things to the user and getting responses from them.
    /// 
    /// Application logic does not belong in this class.
    /// Console WriteLine and ReadLine statements ONLY belong in this class.
    /// </summary>
    public class UserInterface
    {
        private QuestionManager manager = new QuestionManager();
        private FileAccess fileAccess = new FileAccess();

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
                Console.WriteLine("1) List Interview Questions");
                Console.WriteLine("2) Answer a Random Interview Question");
                Console.WriteLine("3) Save Scores");
                Console.WriteLine("4) Exit");
                Console.WriteLine();

                // TODO: Get a value from the user and respond appropriately
                Console.ReadLine();
            }

            Console.WriteLine("Thank you for coming to Sally's for all your interview question needs");
        }
    }
}
