using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    public class Farm
    {
        private readonly List<IMakesNoise> thingsOnFarm;

        public Farm()
        {
            this.thingsOnFarm = new List<IMakesNoise>
            {
                new Dragon(),
                new Horse(),
                new Platypus(),
                new Tractor()
            };
        }

        public bool IsEvening { get; set; }

        public void SingAbout()
        {
            Console.WriteLine("Old MacDonald had a farm ee ay ee ay oh");

            foreach (IMakesNoise thing in this.thingsOnFarm)
            {
                Console.WriteLine($"And on his farm there was a {thing.Name} ee ay ee ay oh");
                Console.WriteLine($"With a {thing.MakeSoundTwice(IsEvening)} here and a {thing.MakeSoundTwice(IsEvening)} there");
                Console.WriteLine($"Here a {thing.MakeSoundOnce(IsEvening)}, there a {thing.MakeSoundOnce(IsEvening)} everywhere a {thing.MakeSoundTwice(IsEvening)}");
                Console.WriteLine("Old Macdonald had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }
        }
    }
}