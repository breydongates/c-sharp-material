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
        // We'll want to create some of our objects here
        private QuestionManager questions;
        private FileAccess files;

        public UserInterface()
        {
            this.questions = new QuestionManager();
            this.files = new FileAccess();
        }

        public void RunInterface()
        {
            files.LoadQuestions(this.questions);

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
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        this.DisplayInterviewQuestions();
                        break;

                    case "3":
                        this.files.WriteScores(this.questions);
                        Console.WriteLine("Your scores have been saved!");
                        break;

                    case "4":
                        done = true;
                        break;

                    default:
                        Console.WriteLine("I don't understand. Try a number 1 - 4");
                        break;
                }
            }

            Console.WriteLine("Thank you for coming to Sally's for all your interview question needs");
        }

        private void DisplayInterviewQuestions()
        {
            Console.WriteLine("Our current questions are: ");

            foreach (InterviewQuestion question in this.questions.AllQuestions)
            {
                Console.WriteLine(question); // will call question.ToString()
            }
        }
    }
}
