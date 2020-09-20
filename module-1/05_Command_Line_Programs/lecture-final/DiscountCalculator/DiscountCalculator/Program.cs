using System;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue; // Move on to the next number
                }

                if (i % 5 == 0)
                {
                    break; // Leave the for loop
                }

                Console.WriteLine(i);
            }
            */

            Console.WriteLine("Welcome to .NET's Discount Calculator");

            string author = "Cohort 12 .NET (CBUS)";

            Console.Write("This application was written by ");
            Console.Write(author);

            Console.WriteLine(" We hope you like it!");

            Console.WriteLine();

            Console.WriteLine("Enter the discount percentage (without a % sign)");

            string discountText = Console.ReadLine();

            // For more learning, look into double.TryParse
            double discountPercent = double.Parse(discountText);

            // discountPercent += 5;

            Console.WriteLine("Your discount is " + discountPercent + " %");
            Console.WriteLine($"Your discount is {discountPercent} %");

            // Get prices from the user
            //bool shouldExit = false;

            //do
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a series of prices separated by spaces OR press Q to exit");

                string priceText = Console.ReadLine();

                if (priceText == "Q" || priceText == "q")
                {
                    //shouldExit = true;
                    break;
                }
                else
                {
                    string[] priceArray = priceText.Split(" ");

                    for (int i = 0; i < priceArray.Length; i++)
                    {
                        double individualPrice = double.Parse(priceArray[i]);

                        double discountAmount = individualPrice * (discountPercent / 100);
                        double discountedPrice = individualPrice - discountAmount;

                        Console.WriteLine($"{individualPrice} is {discountedPrice} discounted.");
                    }
                }
            }
            //while (shouldExit == false);

            Console.WriteLine("Thank you for using our awesome calculator. May your prices be cheap");
        }
    }
}
