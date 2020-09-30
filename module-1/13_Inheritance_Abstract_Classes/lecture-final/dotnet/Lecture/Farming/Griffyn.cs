using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Griffyn : FarmAnimal
    {
        public Griffyn() : base("GRIFFYN")
        {

        }

        public override string MakeSound()
        {
            return "Yo, I gots the head of a hawk";
        }
    }
}
