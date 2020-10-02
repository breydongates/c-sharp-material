using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public class FrontTimesTests
    {
            [TestMethod]
            public void ChoCho()
            {
                //arrange
                FrontTimes front = new FrontTimes();

                //act
                string result = front.GenerateString("Chocolate", 2);

                //assert
                Assert.AreEqual("ChoCho", result);
            }

            [TestMethod]
            public void ChoChoCho()
            {
                //arrange
                FrontTimes front = new FrontTimes();

                //act
                string result = front.GenerateString("Chocolate", 3);

                //assert
                Assert.AreEqual("ChoChoCho", result);
            }

        [TestMethod]
        public void PooPoo()
        {
            //arrange
            FrontTimes front = new FrontTimes();

            //act
            string result = front.GenerateString("Poolside", 2);

            //assert
            Assert.AreEqual("PooPoo", result);
        }

    }
    }
