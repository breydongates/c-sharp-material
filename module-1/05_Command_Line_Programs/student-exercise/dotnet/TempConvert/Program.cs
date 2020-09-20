using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine();
            Console.WriteLine("Please enter the temperature: ");
            
            string tempEnter = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(("Is the temperature in (C)elcius or (F)arenheight?"));
            string cOrF = Console.ReadLine();
           
            
            if (cOrF == "C" || cOrF =="c")
            {
                
                double tempInC = double.Parse(tempEnter);
                double celsiusOutput = ((tempInC -32) / 1.8);
                Console.WriteLine("Your temperature in Celsius is " + celsiusOutput + " degrees Celsius, and " + tempEnter + " degrees Farenheight" );
            }
            else if (cOrF == "F" || cOrF == "f")
            
            {
                double tempInF = double.Parse(tempEnter);
                double farenOutput = (tempInF);
                double farenToCelsius = ((tempInF - 32)/1.8);
                Console.WriteLine("Your temperature in Farenheight is " + farenOutput + " degrees Farenheight, and " + farenToCelsius + " degrees Celsius");
            }
        }
    }
}
