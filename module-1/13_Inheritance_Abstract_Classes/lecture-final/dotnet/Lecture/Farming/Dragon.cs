using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Dragon : FarmAnimal
    {
        public Dragon() : base("DRAGON")
        {

        }

        public override string MakeSound()
        {
            return "Well actually, dragons are quite intelligent.";
        }

        public int VillagersKilled { get; set; }

        public void Fly()
        {

        }
    }
}
