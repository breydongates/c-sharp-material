using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses.Classes;

namespace TestableClassesTests
{
    [TestClass]
    public class FrequentFlyerCardTests
    {
        [TestMethod]
        public void AddingFrequentFlyerMilesShouldIncreaseMiles()
        {
            // arrange
            FrequentFlyerCard card = new FrequentFlyerCard("Vinny");

            //act
            card.AddMiles(5000);
            //assert
            Assert.AreEqual(5000, card.RewardMiles);
        }
    }
}
