using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public abstract class FarmAnimal : IMakesNoise
    {       
        public string Name { get; set; }

        protected FarmAnimal(string name)
        {
            this.Name = name;
        }

        public string MakeSoundOnce(bool isEvening)
        {
            if (isEvening)
            {
                return "ZZzzzzzz";
            }

            return this.MakeSound();
        }

        public abstract string MakeSound();

        /*
        public virtual string MakeSoundOnce(bool isEvening)
        {
            // Maybe the default behavior should care if it's evening?

            return "";

            // What if we had a separate MakeSound method that each inheriting class had to implement?
        }
        */

        public string MakeSoundTwice(bool isEvening)
        {
            return this.MakeSoundOnce(isEvening) + " " + this.MakeSoundOnce(isEvening);
        }

        public virtual void Pet()
        {

        }

        public void Butcher()
        {
            // Sorry
        }
    }
}
