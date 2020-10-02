using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Tests
    {
        [TestMethod]
        public void EightteenIsTrue()
        {
            //arrange
            Less20 less = new Less20();

            //act
            bool result = less.IsLessThanMultipleOf20(18);

            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TwentyIsFalse()
        {
            //arrange
            Less20 less = new Less20();

            //act
            bool result = less.IsLessThanMultipleOf20(20);

            //assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void NineteenIsTrue()
        {
            //arrange
            Less20 less = new Less20();

            //act
            bool result = less.IsLessThanMultipleOf20(19);

            //assert
            Assert.AreEqual(true, result);
        }
    }
}
