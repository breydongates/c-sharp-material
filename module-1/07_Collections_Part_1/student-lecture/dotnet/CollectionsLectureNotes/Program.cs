using System;

namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.

            // Creating lists of integers


            // Creating lists of strings

            /////////////////

            // Discuss namespaces & using statements

            //////////////////
            // OBJECT EQUALITY
            //////////////////

            // Check reference equality

            // Compare two variables pointed at the same list

            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list

            // ADDING MULTIPLE ITEMS

            // LIST INITIALIZER

            //////////////////
            // ACCESSING BY INDEX
            //////////////////



            ///////////////////
            // ACCESSING WITH FOREACH
            ///////////////////



            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////

            // Contains

            // IndexOf

            // Insert

            // Remove

            // List to Array

            // Array to List

            ////////////////////////
            // SORT / REVERSE
            ////////////////////////



            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////

            // Enqueue

            // Loop through and Dequeue


            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 


            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 



            ////////////////////
            // POPPING THE STACK
            ////////////////////

            ////////////////////
            // SWITCH STATEMENTS
            ////////////////////
            ///
            bool timeForSwitchStatements = false;

            if (timeForSwitchStatements)
            {
                Console.WriteLine();

                string favoriteLanguage = "C#";

                switch (favoriteLanguage)
                {
                    case "C#":
                        Console.WriteLine("I love C#!");
                        break;

                    case "Java":
                        Console.WriteLine("Java is definitely a programming language");
                        break;

                    case "JavaScript":
                        Console.WriteLine("JavaScript is to Java as Carpet is to Car");
                        break;

                    default:
                        Console.WriteLine($"I don't have much to say about {favoriteLanguage}");
                        break;
                }

                // This is equivalent to the code below:
                if (favoriteLanguage == "C#")
                {
                    Console.WriteLine("I love C#!");
                }
                else if (favoriteLanguage == "Java")
                {
                    Console.WriteLine("Java is definitely a programming language");
                }
                else if (favoriteLanguage == "JavaScript")
                {
                    Console.WriteLine("JavaScript is to Java as Carpet is to Car");
                }
                else
                {
                    Console.WriteLine($"I don't have much to say about {favoriteLanguage}");
                }
            }

            Console.ReadLine();
        }
    }
}
