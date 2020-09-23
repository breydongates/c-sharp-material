using System;
using System.Collections.Generic;

namespace HashSetExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello HashSets!");

            string input = "";

            HashSet<string> flavors = new HashSet<string>();

            while (input.ToLower() != "exit")
            {
                Console.WriteLine("Enter a flavor of soda or type 'Exit' to quit.");

                input = Console.ReadLine();

                // 2. Check to see if the HashSet contains what we're looking for
                /*
                if (flavors.Contains(input))
                {
                    Console.WriteLine("I already have that!");
                } 
                else
                {
                    flavors.Add(input);
                }
                */

                flavors.Add(input);

                // 3. If the HashSet doesn't have what we're looking for, add it

                // 5. Get rid of the contains check and see what changes
            }

            // 4. List all flavors in the hash set
            foreach (string flavor in flavors)
            {
                Console.WriteLine("Drink more " + flavor);
            }

            if (flavors.Contains("Slurm"))
            {
                Console.WriteLine("But we have Slurm, and that's all I need!");
            }

            int[] numbers = { 1, 1, 2, 3, 5, 8, 5 };
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
            /*
            foreach (int number in numbers)
            {
                uniqueNumbers.Add(number);
            }
            */

            /* For Anna
            Dictionary<string, int> logAccesses = new Dictionary<string, int>();

            logAccesses["Fred"] = 0;

            logAccesses["Fred"] = logAccesses["Fred"] + 1;
            */

            Console.WriteLine();
            Console.WriteLine("Have a great day!");
        }
    }
}
