using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface IMakesNoise
    {
        string Name { get; }
        string MakeSoundOnce(bool isEvening);
        string MakeSoundTwice(bool isEvening);
    }
}
