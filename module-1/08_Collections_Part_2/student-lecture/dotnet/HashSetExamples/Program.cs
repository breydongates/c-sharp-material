using System;

namespace HashSetExamples
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello HashSets!");

            string input = "";

            while (input.ToLower() != "exit")
            {
                Console.WriteLine("Enter a flavor of soda or type 'Exit' to quit.");

                input = Console.ReadLine();

                // 2. Check to see if the HashSet contains what we're looking for

                // 3. If the HashSet doesn't have what we're looking for, add it

                // 5. Get rid of the contains check and see what changes
            }

            // 4. List all flavors in the hash set

            Console.WriteLine();
            Console.WriteLine("Have a great day!");
        }
    }
}
