using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public class Tractor : IMakesNoise
    {
        public string Name
        {
            get
            {
                return "Tractorzilla";
            }
        }

        public string MakeSoundOnce(bool isEvening)
        {
            if (isEvening)
            {
                return "...";
            }

            return "vvvvvvvvvvvvvvvroooooom";
        }

        public string MakeSoundTwice(bool isEvening)
        {
            if (isEvening)
            {
                return "...";
            }

            return "VRRRRRROOOOOOOOOOOOM";
        }

        public void PlowField()
        {

        }
    }
}
