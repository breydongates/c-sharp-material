using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public abstract class Cat : FarmAnimal
    {
        // this.Documentation == null

        public Cat() : base("CAT")
        {

        }

        protected void BeAloof()
        {

        }

        public abstract void Purr();

        /*
        public override string MakeSoundOnce(bool isEvening)
        {
            if (isEvening)
            {
                return "Zzzzzzzzzzzzz";
            }

            return "Hssssssssss";
        }
        */
    }

    public sealed class CheshireCat : Cat
    {
        public override string MakeSound()
        {
            return "Hmmmmmmmm";
        }

        public override void Purr()
        {
            this.BeAloof(); // Fine since it's protected
        }
    }

    /*
    public class PurpleCheshireCat : CheshireCat
    {

    }
    */
}
