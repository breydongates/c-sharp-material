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
            // Arrange
            FrequentFlyerCard card = new FrequentFlyerCard("Vinny");
            int initialMiles = card.RewardMiles;
            int milesToAdd = 5000;

            // Act
            card.AddMiles(milesToAdd);

            // Assert
            int expected = initialMiles + milesToAdd;
            Assert.AreEqual(expected, card.RewardMiles);
        }

        [TestMethod]
        public void StringUpperCaseWorksForFirstString()
        {
            // Arrange
            StringHelper helper = new StringHelper();
            string[] otherStrings = { "Hello", "World" };

            // Act
            string[] result = helper.ConvertToUpperCase(otherStrings);

            // Assert
            Assert.AreEqual("HELLO", result[0]);
            // Assert.AreEqual("WORLD", result[1]);
        }
    }
}
