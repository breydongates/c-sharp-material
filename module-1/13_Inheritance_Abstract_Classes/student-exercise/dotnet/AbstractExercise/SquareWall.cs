using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractExercise
{
    public class SquareWall:RectangleWall
    {
        
        public int SideLength { get; }
        public SquareWall(string name, string color, int sideLength) :base (name, color, sideLength,sideLength)
        {
            this.SideLength = sideLength;
        }
        public override string ToString()
        {
            return Name + " (" + this.SideLength + "x" + this.SideLength + ") square";
        }
    }
}
