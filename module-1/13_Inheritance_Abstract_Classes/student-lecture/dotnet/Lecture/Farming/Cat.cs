using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public abstract class Cat :FarmAnimal
    {
        public Cat() :base("CAT")
        {

        }


        public abstract void Purr();

    }
}
