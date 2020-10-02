using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass]
    public class KataFizzBuzzTests
    {
        [TestMethod]
        [DataRow(1, "1")]
        public void IntShouldReturnFizzWhenNumberIsThree(int inputNumbers, string exportStrings)
        {
            KataFizzBuzz fizz = new KataFizzBuzz();
            //arrange

            //act
            string result = fizz.NumsToString(inputNumbers);

            //assert
            Assert.AreEqual(exportStrings, result);
        }
    }
}
