using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
   //public  class MakesNoise
   // {
   //     public string Name { get; }

   //     public string MakeSoundOnce()
   //     {
   //         return "";
   //     }

   //     public string MakeSoundTwice()
   //     {
   //         return "";
   //     }
   // }

    public interface IMakesNoise
    {
        string Name { get; }

        string MakeSoundOnce();
        string MakeSoundTwice();

        //int Volume { get; set; }
    }
}
