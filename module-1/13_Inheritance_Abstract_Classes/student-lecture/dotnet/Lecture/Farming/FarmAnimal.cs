using System;
using System.Collections.Generic;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : Object, IMakesNoise
    {       
        public string Name { get; set; }

        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        public virtual string MakeSoundOnce()
        {
            return "";
        }

        public string MakeSoundTwice()
        {
            return this.MakeSoundOnce() + " " + this.MakeSoundOnce();
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
