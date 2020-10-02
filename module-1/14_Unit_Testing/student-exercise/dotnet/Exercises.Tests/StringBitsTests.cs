using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public class StringBitsTests
    {
        [TestMethod]
        public void Hlo()
        {
            //arrange
            StringBits bits = new StringBits();

            //act
            string result = bits.GetBits("Hello");

            //assert

            Assert.AreEqual("Hlo", result);
        }

        [TestMethod]
        public void H()
        {
            //arrange
            StringBits bits = new StringBits();

            //act
            string result = bits.GetBits("Hi");

            //assert

            Assert.AreEqual("H", result);
        }

        [TestMethod]
        public void Hello()
        {
            //arrange
            StringBits bits = new StringBits();

            //act
            string result = bits.GetBits("Heeololeo");

            //assert

            Assert.AreEqual("Hello", result);
        }
    }
}
