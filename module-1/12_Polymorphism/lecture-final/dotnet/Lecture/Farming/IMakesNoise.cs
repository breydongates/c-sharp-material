using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface IMakesNoise
    {
        string Name { get; }
        string MakeSoundOnce();
        string MakeSoundTwice();

        // int Volume { get; set; }
    }

    public interface IRusts
    {
        void Rust(int numTimes);
    }


    /*
    public class MakesNoise
    {
        public string Name { get; }

        public string MakeSoundOnce()
        {
            return "";
        }

        public string MakeSoundTwice()
        {
            return "";
        }
    }
    */
}
