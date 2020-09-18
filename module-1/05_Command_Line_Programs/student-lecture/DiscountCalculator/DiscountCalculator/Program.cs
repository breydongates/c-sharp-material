using System;

namespace DiscountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.WriteLine("Welcome to .NET's Discount Calculator!");

            string author = "Cohort 12 .NET (CBUS)";

            Console.Write("This application was written by ");
            Console.Write(author);
            Console.WriteLine(" We hope you like it!");

            Console.WriteLine();

            Console.WriteLine("Enter the discount percentage (without a % sign)");

            string discountText = Console.ReadLine();

            // for more learning, look into dobule.TryParse

            double discountPercent = double.Parse(discountText);

           // discountPercent += 5;


            Console.WriteLine("Your discount is " + discountPercent + "%");
            Console.WriteLine($"Your discount is {discountPercent} %");// <--- this does the same thing as above

            // get prices from user
            bool shouldExit = false;

            while (shouldExit == false)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter a series of prices separated by spaces OR press Q to exit.");

                string priceText = Console.ReadLine();

                if (priceText == "Q" || priceText == "q")
                {
                    shouldExit = true;
                }
                else
                {

                    string[] priceArray = priceText.Split(" ");

                    for (int i = 0; i < priceArray.Length; i++)
                    {
                        double individualPrice = double.Parse(priceArray[i]);

                        double discountedAmount = individualPrice * (discountPercent / 100);
                        double discountedPrice = individualPrice - discountedAmount;
                        Console.WriteLine(individualPrice + " is " + discountedPrice + " discounted.");
                        //can also be written as    Console.WriteLine($"{individualPrice} is {discountedAmount} discounted");
                    }
                }
            }
            Console.WriteLine("Thank you for using our awesome calculator.");



        }
    }
}
