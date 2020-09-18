using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 42;

            Console.WriteLine(myNum);

            //myNum = myNum + 1;
            //myNum += 1;

            // Increment
            myNum++;
            Console.WriteLine(myNum);

            // Decrement
            myNum--; // myNum -= 1;
            Console.WriteLine(myNum);

            // Generate a random number between 0 and 4.
            Random random = new Random();
            int number = random.Next(0, 5);

            Console.WriteLine("The magic number is " + number);

            // Use a while loop to print out numbers < the Random number

            // Use a do..while loop to print out numbers < the Random number
        }
    }
}
