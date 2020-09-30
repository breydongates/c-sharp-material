using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class  RectangleWall : Wall
    {
        public int Length { get; }
        public int Height { get; }
        public RectangleWall(string name, string color, int length, int height) : base(name, color)
        {
            this.Length = length;
            this.Height = height;
        }
        public override int GetArea()
        {
            return Length * Height;
        }
        public override string ToString()
        {
            return Name + " (" + this.Length + "x" + this.Height + ") rectangle";
        }



    }
}
