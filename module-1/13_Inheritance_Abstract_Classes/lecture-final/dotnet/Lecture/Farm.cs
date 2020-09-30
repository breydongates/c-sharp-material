using Lecture.Farming;
using System;
using System.Collections.Generic;

namespace Lecture
{
    /// <summary>
    /// Manages everything related to singing about everything on a farm
    /// </summary>
    public class Farm
    {
        private readonly List<IMakesNoise> thingsOnFarm = new List<IMakesNoise>();

        /// <summary>
        /// Creates a new instance of a Farm and marks it as owned by owner.
        /// </summary>
        /// <param name="owner">The owner of the farm</param>
        public Farm(string owner)
        {
            this.Owner = owner;
        }

        public string Owner { get; set; }

        /// <summary>
        /// Adds an IMakesNoise thing to the farm.
        /// </summary>
        /// <param name="thing">The thing to add to the farm</param>
        public void Add(IMakesNoise thing)
        {
            // this.thingsOnFarm = new List<IMakesNoise>();
            this.thingsOnFarm.Add(thing);
        }

        /// <summary>
        /// Gets or sets whether or not it is evening. 
        /// If it is evening, things on the farm will behave differently.
        /// </summary>
        public bool IsEvening { get; set; }

        /// <summary>
        /// Sing about everything currently in the farm
        /// </summary>
        public void SingAbout()
        {
            Console.WriteLine($"{this.Owner} had a farm ee ay ee ay oh");
            Console.WriteLine();

            foreach (IMakesNoise thing in this.thingsOnFarm)
            {
                Console.WriteLine($"And on his farm there was a {thing.Name} ee ay ee ay oh");
                Console.WriteLine($"With a {thing.MakeSoundTwice(IsEvening)} here and a {thing.MakeSoundTwice(IsEvening)} there");
                Console.WriteLine($"Here a {thing.MakeSoundOnce(IsEvening)}, there a {thing.MakeSoundOnce(IsEvening)} everywhere a {thing.MakeSoundTwice(IsEvening)}");
                Console.WriteLine($"{this.Owner} had a farm, ee ay ee ay oh");
                Console.WriteLine();
            }
        }
    }
}