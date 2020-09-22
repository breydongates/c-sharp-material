using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Matt" + " " + "Eland";
            string friendName = "Matt";

            // bool sameName = myName == friendName; // Strings use value equality

            // friendName = "Batman"; // Only changes my friend's name, doesn't change mine

            Console.WriteLine(myName);
            Console.WriteLine(friendName);
            Console.WriteLine(friendName[friendName.Length - 1]);

            friendName = "Math";

            // Second Part of Lecture Starts Here

            string name = "Ada Lovelace";              

            // Strings are actually arrays of characters (char). 
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e
            Console.WriteLine(name[0]);
            Console.WriteLine(name[name.Length - 1]);

            // Console.WriteLine("First and Last Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada

            Console.WriteLine("First 3 characters: ");
            Console.WriteLine(name.Substring(0, 3));

            // 3. Now print out the first three and the last three characters
            // Output: Adaace

            Console.WriteLine("Last 3 characters: ");

            Console.WriteLine(name.Substring(name.Length - 3, 3));
            Console.WriteLine(name.Substring(name.Length - 3)); // Omitting length takes everything to the end of the string

            if (name.ToLower()
                    .Replace("goodbye", "hello")
                    .Contains("Love"))
            {

            }

            char[] separators = { ' ', ',', '.', '?', ';' };
            string[] values = name.Split(separators);

            // 4. What about the last word?
            // Output: Lovelace

            string[] words = name.Split(" ");
            // Console.WriteLine(words[0]);

            Console.WriteLine("Last Word: ");
            Console.WriteLine(words[1]);

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\" " + name.Contains("Love"));
            Console.WriteLine(name.StartsWith("Ada"));
            Console.WriteLine(name.EndsWith("ace"));

            // 6. Where does the string "lace" show up in name?
            // Output: 8

            Console.WriteLine("Index of \"lace\": " + name.IndexOf("lace"));

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3
            int count = 0;
            string lowerCasedName = name.ToLower();
            for (int i = 0; i < lowerCasedName.Length; i++)
            {
                char letter = lowerCasedName[i];

                if (letter == 'a')
                {
                    count++;
                }
            }
            Console.WriteLine("Number of \"a's\": " + count);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"

            name = name.Replace("Ada", "Ada, Countess of Lovelace");

            Console.WriteLine(name);

            // 9. Set name equal to null.

            name = null;
            name = "";

            // name = name.ToUpper(); // You cannot call a method on something that is null

            // 10. If name is equal to null or "", print out "All Done".
            //if (name == null || name == "")
            //if (string.IsNullOrEmpty(name))
            if (string.IsNullOrWhiteSpace(name)) // Same is IsNullOrEmpty, but also not just spaces
            {
                Console.WriteLine("All done!");
            }

            Console.ReadLine();
        }
    }
}