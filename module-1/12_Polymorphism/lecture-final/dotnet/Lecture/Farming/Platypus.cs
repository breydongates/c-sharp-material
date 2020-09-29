using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Platypus : FarmAnimal
    {
        public Platypus() : base("PLATYPUS")
        {

        }

        public override string MakeSoundOnce()
        {
            return "gnaaabruh Purr";
        }

        public void ThumpTail()
        {
            
        }

        public int SpellingErrorsMade { get; set; } = 1;
    }
}
