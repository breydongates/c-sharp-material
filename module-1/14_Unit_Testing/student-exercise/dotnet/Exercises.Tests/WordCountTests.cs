using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
   public class WordCountTests
    {
        [TestMethod]
        public void BaBaBlackSheep()
        {
            //address
            WordCount count = new WordCount();
            string[] sheep = { "ba", "ba", "black", "sheep" };

            Dictionary<string, int> result = count.GetCount(sheep);

            //act
            //assert
            Assert.AreEqual(2, result["ba"]);
        }

        [TestMethod]
        public void ABC()
        {
            //address
            WordCount count = new WordCount();
            string[] abc = { "A", "B","C" };

            Dictionary<string, int> result = count.GetCount(abc);

            //act
            //assert
            Assert.AreEqual(1, result["B"]);
        }
        [TestMethod]
        public void ABCABCABC()
        {
            //address
            WordCount count = new WordCount();
            string[] abc = { "A", "B", "C", "A", "B", "C", "A", "B", "C" };

            Dictionary<string, int> result = count.GetCount(abc);

            //act
            //assert
            Assert.AreEqual(3, result["C"]);
        }
    }
}
