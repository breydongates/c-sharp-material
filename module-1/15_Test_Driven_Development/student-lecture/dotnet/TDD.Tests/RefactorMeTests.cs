using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests
{
    [TestClass]
    public class RefactorMeTests
    {
        [TestMethod]
        [DataRow("Chocolate", 2, "ChoCho")]
        [DataRow("Chocolate", 3, "ChoChoCho")]
        [DataRow("Abc", 3, "AbcAbcAbc")]
        [DataRow("Ab", 3, "AbAbAb")]
        [DataRow("A", 4, "AAAA")]
        [DataRow("", 4, "")]
        [DataRow("Abc", 0, "")]
        public void FrontTimes(string input, int numTimes, string expected)
        {
            // Arrange
            RefactorMe exercises = new RefactorMe();

            // Act
            string actual = exercises.FrontTimes(input, numTimes);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
