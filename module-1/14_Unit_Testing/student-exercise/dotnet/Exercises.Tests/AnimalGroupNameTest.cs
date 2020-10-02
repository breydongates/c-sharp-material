using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Exercises.Tests;

namespace Exercises.Tests
{
    [TestClass]
   public class AnimalGroupNameTest
    {
        [TestMethod]

    public void RhinoShouldReturnCrash()
        {
            // arange
            AnimalGroupName groupName = new AnimalGroupName();
            string result = groupName.GetHerd("Rhino");

            //act
            groupName.GetHerd("Rhino");

            //assert
            Assert.AreEqual("Crash", result);
        }

        [TestMethod]
            public void GiraffeUpperCaseShouldReturnTower()
        {
            // arange
            AnimalGroupName groupName = new AnimalGroupName();
            string result = groupName.GetHerd("GIRAFFE");

            //act
            groupName.GetHerd("GIRAFFE");

            //assert
            Assert.AreEqual("Tower", result);
        }

        [TestMethod]
        public void FishShouldReturnUnknown()
        {
            //arrange
            AnimalGroupName groupName = new AnimalGroupName();
            string result = groupName.GetHerd("Fish");

            //act
            groupName.GetHerd("Fish");

            //assert
            Assert.AreEqual("unknown", result);
        }





    }
}
