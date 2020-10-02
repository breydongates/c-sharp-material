using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTests
    {
        [TestMethod]
       public void TwoUnfashionables()
        {
            //Arrange
            DateFashion table = new DateFashion();

            //act
            int result = table.GetATable(1, 1);


            //assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TwoFashionables()
        {
            //Arrange
            DateFashion table = new DateFashion();

            //act
            int result = table.GetATable(10, 10);


            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void AMaybe()
        {
            //Arrange
            DateFashion table = new DateFashion();

            //act
            int result = table.GetATable(5,7);


            //assert
            Assert.AreEqual(1, result);
        }
    }
}
