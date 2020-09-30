using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class TriangleWall : Wall
    {
        public TriangleWall(string name, string color, int @base, int height) : base(name, color)
        {
            this.Base = @base;
            this.Height = height;

        }
        public int Base { get; }

        public int Height { get; }
        public override int GetArea()
        {
            return (this.Base * this.Height) / 2;
        }

        public override string ToString()
        {
            return Name + " (" + this.Base + "x" + this.Height + ") triangle";
        }

    }
}
