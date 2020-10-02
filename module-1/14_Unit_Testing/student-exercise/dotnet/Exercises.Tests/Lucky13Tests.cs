using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Tests
    {
        [TestMethod]
        public void OneTwoThree ()
        {
            //arrange 
            Lucky13 lucky = new Lucky13();
            int[] numbers = { 1, 2, 3 };
            //act
            bool result = lucky.GetLucky(numbers);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TwoTwoTwo()
        {
            //arrange 
            Lucky13 lucky = new Lucky13();
            int[] numbers = { 2, 2, 2};
            //act
            bool result = lucky.GetLucky(numbers);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void FourFourOne()
        {
            //arrange 
            Lucky13 lucky = new Lucky13();
            int[] numbers = { 4, 4, 1};
            //act
            bool result = lucky.GetLucky(numbers);

            //assert
            Assert.AreEqual(false, result);
        }
    }
}
