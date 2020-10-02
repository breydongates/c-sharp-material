using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTests
    {
        [TestMethod]

        public void ellohere()
        {
            //arrange
            NonStart start = new NonStart();
            //act
            string result = start.GetPartialString("Hello", "There");

            //assert
            Assert.AreEqual("ellohere", result);
        }

        [TestMethod]

        public void avaode()
        {
            //arrange
            NonStart start = new NonStart();
            //act
            string result = start.GetPartialString("java", "code");

            //assert
            Assert.AreEqual("avaode", result);
        }

        [TestMethod]

        public void hotdog()
        {
            //arrange
            NonStart start = new NonStart();
            //act
            string result = start.GetPartialString("Shot","ddogs");

            //assert
            Assert.AreEqual("hotdogs", result);
        }

    }
}
