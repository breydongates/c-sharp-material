using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTests
    {
        [TestMethod]

        public void SeventyCigarsOnTheWeekend()
        {
            //arrange
            CigarParty party = new CigarParty();
            
            //act
            bool result = party.HaveParty(70, true) ;


            //assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]

        public void SeventyCigarsDuringTheWeek()
        {
            //arrange
            CigarParty party = new CigarParty();

            //act
            bool result = party.HaveParty(70, false);


            //assert
            Assert.AreEqual(false ,result);
        }

        [TestMethod]

        public void TenCigarsOnTheWeekend()
        {
            //arrange
            CigarParty party = new CigarParty();

            //act
            bool result = party.HaveParty(10, true);


            //assert
            Assert.AreEqual(false , result);
        }



    }
}
