using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Tests
    {
        [TestMethod]

        public void ShouldReturnTripleFours()
        {
            //arrange
            MaxEnd3 max = new MaxEnd3();
            int[] numbers = { 1, 2, 4 };
            int[] expected = { 4, 4, 4 };
            //act
            int[] result = max.MakeArray(numbers);


            //assert
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]

        public void ShouldReturnTripleSix()
        {
            //arrange
            MaxEnd3 max = new MaxEnd3();
            int[] numbers = { 4, 1, 6};
            int[] expected = { 6, 6, 6};
            //act
            int[] result = max.MakeArray(numbers);


            //assert
            CollectionAssert.AreEqual(expected, result);

        }

        [TestMethod]

        public void ShouldReturnTripleFortyTwo()
        {
            //arrange
            MaxEnd3 max = new MaxEnd3();
            int[] numbers = { 1, 0, 42 };
            int[] expected = { 42, 42, 42};
            //act
            int[] result = max.MakeArray(numbers);


            //assert
            CollectionAssert.AreEqual(expected, result);

        }


    }
}
