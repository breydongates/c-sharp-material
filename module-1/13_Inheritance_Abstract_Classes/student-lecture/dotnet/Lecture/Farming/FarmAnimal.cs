using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : IMakesNoise
    {       
        public string Name { get; set; }

        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        public virtual string MakeSoundOnce(bool isEvening)
        {
            // Maybe the default behavior should care if it's evening?

            return "";

            // What if we had a separate MakeSound method that each inheriting class had to implement?
        }

        public string MakeSoundTwice(bool isEvening)
        {
            return this.MakeSoundOnce(isEvening) + " " + this.MakeSoundOnce(isEvening);
        }

        public void Pet()
        {

        }

        public void Butcher()
        {
            // Sorry
        }
    }
}
