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
            return "";
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
