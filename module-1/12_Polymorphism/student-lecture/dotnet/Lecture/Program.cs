using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    class Program
    {
        static void Main()
        {
            //
            // OLD MACDONALD
            //
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");


            List<IMakesNoise> farm = new List<IMakesNoise>();
            farm.Add(new Dragon());
            farm.Add(new Horse());
            farm.Add(new Platypus());
           farm.Add(new Tractor());
            // Let's try singing about a Farm Animal
            //FarmAnimal animal;
            //animal = new Dragon();



            // Can we swap out any animal in place here?

            // What about a few other animals?

            //Horse horse = (Horse)animal;
            //horse.Gallup();


            // What about tractors?
            foreach (IMakesNoise animal in farm)
            {
                Console.WriteLine($"And on his farm there was a {animal.Name} ee ay ee ay oh");
                Console.WriteLine($"With a {animal.MakeSoundTwice()} here and a {animal.MakeSoundTwice()} there");
                Console.WriteLine($"Here a {animal.MakeSoundOnce()}, there a {animal.MakeSoundOnce()} everywhere a {animal.MakeSoundTwice()}");
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}