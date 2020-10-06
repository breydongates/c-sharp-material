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
            int initialMiles = card.RewardMiles;
            int milesToAdd = 5000;
            //act
            card.AddMiles(milesToAdd);
            //assert
            int expected = initialMiles + milesToAdd;
            Assert.AreEqual(expected, card.RewardMiles);
        }

        [TestMethod]
        public void StringUpperCaseWorksForFirstString()
        {
            //arrange
            StringHelper helper = new StringHelper();
            string[] otherStrings = {"Hello", "World" };
            //act

           string[] result = helper.ConvertToUpperCase(otherStrings);
            //assert
            Assert.AreEqual("HELLO", result[0]);
           // Assert.AreEqual("WORLD", result[1]);


        }
    }

}
