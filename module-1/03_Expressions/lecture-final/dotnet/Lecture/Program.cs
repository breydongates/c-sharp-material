using System;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string message = null;
            Console.WriteLine(message);

            int someNumber = 0;
            Console.WriteLine(someNumber);

            Console.WriteLine("Message is above ^");

            // TODO: Talk about casting

            // TODO: Talk about double / decimal / float

            double someDouble = 4.2;
            decimal someDecimal = 4.2M;
            decimal someOtherDecimal = (decimal)4.2;
            float someFloat = 4.2F;

            int someInt = (int)someDouble;
            Console.WriteLine(someInt);

            // how do you write out something like x=(53-2)/3
            // If two lemon cupcakes were left at home, how many boxes 
            // with 3 lemon cupcakes each were given away

            int numCupcakes = 53;
            int numLeftAtHome = 1;

            const int cupcakesPerBox = 3; // Const is a variable that cannot change

            int boxes = (numCupcakes - numLeftAtHome) / cupcakesPerBox; // 17

            Console.WriteLine("We'll need " + boxes + " boxes");

            if (boxes < 7)
            {
                Console.WriteLine("We'll need more boxes");
            }
            else if (boxes > 15)
            {
                Console.WriteLine("That's a lot of boxes!");
                Console.WriteLine("Great googely moogely - the boxes!");
            }
            else
            {
                Console.WriteLine("We have plenty of boxes for this");
            }
        }
    }
}
