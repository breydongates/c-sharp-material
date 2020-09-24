using System;
using System.Collections.Generic;

namespace DictionaryCollection
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Person / Height Database");
            Console.WriteLine();

            Console.Write("Would you like to enter another person (yes/no)? ");
            string input = Console.ReadLine().ToLower();

            // 1. Let's create a new Dictionary that let's us store heights by names
            //      | "Mal"    | 70 |
            //      | "Simon"  | 72 |
            //      | "Kaylee" | 75 |
            //      | "Inara"  | 73 |
            Dictionary<string, int> people = new Dictionary<string, int>();

            while (input == "yes" || input == "y")
            {
                Console.Write("What is the person's name?: ");
                string name = Console.ReadLine().ToLower();

                Console.Write("What is the person's height (in inches)?: ");
                int height = int.Parse(Console.ReadLine());

                // 2. Check to see if that name is in the dictionary
                bool exists = people.ContainsKey(name);

                if (!exists)
                {
                    Console.WriteLine($"Adding {name} with new value.");
                    //Console.WriteLine("Adding " + name + " with new value.");

                    // 3. Put the name and height into the dictionary
                    // people.Add(name, height); // Will error if key already adds
                    people[name] = height; // Will add or update the key of name's value
                }
                else
                {
                    Console.WriteLine($"Overwriting {name} with new value.");

                    // 4. Overwrite the current key with a new value
                    people[name] = height;
                }

                Console.WriteLine();
                Console.Write("Would you like to enter another person (yes/no)? ");
                input = Console.ReadLine().ToLower();
            }

            Console.Write("Type \"all\" to print all names OR \"search\" to print out single name: ");
            input = Console.ReadLine().ToLower();

            if (input == "search")
            {
                Console.Write("Which name are you looking for? ");
                string nameToFind = Console.ReadLine().ToLower();

                //5. Let's get a specific name from the dictionary
                if (people.ContainsKey(nameToFind))
                {
                    Console.WriteLine($"{nameToFind} is {people[nameToFind]} inches tall!");
                } 
                else
                {
                    Console.WriteLine($"{nameToFind} does not exist!");
                }
            }
            else if (input == "all")
            {
                Console.WriteLine();
                Console.WriteLine(".... printing ...");

                //6b. Let's print each item in the dictionary
                PrintDictionary(people);
            }

            Console.WriteLine();
            Console.WriteLine("Done...");

            //7. Let's get the average height of the people in the dictionary
            int totalHeight = 0;
            foreach (int height in people.Values)
            {
                totalHeight += height;
            }
            int avgHeight = totalHeight / people.Count;
            Console.WriteLine("Our average height is " + avgHeight);

            Console.ReadLine();
        }

        static void PrintDictionary(Dictionary<string, int> database)
        {
            // 6a.
            // Looping through a dictionary involves using a foreach loop
            // to look at each item, which is a key-value pair
            foreach (KeyValuePair<string, int> kvp in database)
            {
                Console.WriteLine($"{kvp.Key} is {kvp.Value} inches tall");
            }
        }
    }
}
