using System;
using System.Collections.Generic;
using System.Text;

namespace TestableClasses.Classes
{
    public class FrequentFlyerCard
    {
        public FrequentFlyerCard(string owner)
        {
            this.Owner = owner;
            this.RewardMiles = 1000;
        }

        public string Owner { get; }

        public int RewardMiles { get; private set; }

        public void AddMiles(int miles)
        {
            this.RewardMiles += miles;
        }

        public bool RedeemMiles(int miles)
        {
            if (this.RewardMiles < miles)
            {
                // Not enough miles to redeem
                return false;
            }

            this.RewardMiles -= miles;

            return true;
        }
    }
}
