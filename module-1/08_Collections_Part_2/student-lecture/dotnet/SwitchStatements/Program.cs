using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main()
        {
            string favoriteLanguage = "C#";

            bool useIfElse = true;

            if (useIfElse)
            {
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
            else
            {
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
            }

            Console.ReadLine();
        }
    }
}
