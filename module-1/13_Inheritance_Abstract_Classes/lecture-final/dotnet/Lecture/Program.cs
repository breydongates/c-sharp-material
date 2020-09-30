using Lecture.Farming;
using System;

namespace Lecture
{
    class Program
    {
        static void Main()
        {
            // Old MacDonald's farm is now in a class!
            Farm farm = new Farm("Old MacDonald");

            // Add all of our animals and a tractor
            farm.Add(new Dragon());
            farm.Add(new Horse());
            farm.Add(new Platypus());
            farm.Add(new Tractor());
            // farm.Add(new FarmAnimal("Cat"));
            farm.Add(new CheshireCat());
            // What happens if he gets a cat? (or a generic animal)
            farm.Add(new Griffyn());

            // Changing the time of day changes if animals make noise or sleep
            farm.IsEvening = false;

            // Sing about everything on the farm
            farm.SingAbout();

            Console.ReadLine();
        }
    }
}