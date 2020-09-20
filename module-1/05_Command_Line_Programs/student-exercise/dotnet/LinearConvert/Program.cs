using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the length: ");

            string lengthEnter = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(("Is the distance in (M)eters or (F)eet?"));
            string mOrF = Console.ReadLine();


            if (mOrF == "M" || mOrF == "m")
            {

                double distInM = double.Parse(lengthEnter);
                double metersOutput = (distInM * 0.3048);
                Console.WriteLine("Your length in meters is " + metersOutput + " m, and " + lengthEnter + " f");
            }
            else if (mOrF == "F" || mOrF == "f")

            {
                double distInF = double.Parse(lengthEnter);
                double feetOutput = (distInF);
                double feetToMeters = (distInF * 0.3048);
                Console.WriteLine("Your length in feet is " + feetOutput + " f, and " + feetToMeters + " m");
            }
        }
    }
}
