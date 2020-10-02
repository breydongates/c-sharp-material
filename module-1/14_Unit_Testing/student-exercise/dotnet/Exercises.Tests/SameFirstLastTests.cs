using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTests
    {
        [TestMethod]

        public void NotEqualThreeAndOne()
        {
            //arrange 
            SameFirstLast firstLast = new SameFirstLast();
            int[] numbers = { 1, 2, 3, 4, 3 };
            //act
            bool result = firstLast.IsItTheSame(numbers);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]

        public void EqualsTwoAndTwo()
        {
            //arrange 
            SameFirstLast firstLast = new SameFirstLast();
            int[] numbers = { 2, 3, 4, 2};
            //act
            bool result = firstLast.IsItTheSame(numbers);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]

        public void NotEqualsTwoAndFour()
        {
            //arrange 
            SameFirstLast firstLast = new SameFirstLast();
            int[] numbers = { 2, 1, 2, 4 };
            //act
            bool result = firstLast.IsItTheSame(numbers);

            //assert
            Assert.AreEqual(false, result);
        }
    }
}
