using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;

namespace TestableClassesTests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorShouldAddTwoAndTwoCorrectly()
        {
            // Arrange  - Set up the code we want to test
            Calculator calc = new Calculator();

            // Act      - Do some form of an action that we want to verify is correct
            int result = calc.Add(2, 2);

            // Assert   - Verify that the system under test behaved the way we wanted it to
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void CalculatorShouldAddTenAndFiveCorrectly()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Add(10, 5);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void CalculatorShouldDivideFiveAndThree()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Divide(5, 3);

            // Assert
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void CalculatorShouldDivideByZero()
        {
            // Arrange
            Calculator calc = new Calculator();

            // Act
            int result = calc.Divide(5, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculatorShouldReturnLargestNumber()
        {
            // Arrange
            Calculator calc = new Calculator();
            int[] numbers = { 3, 5, 42, 7 };

            // Act
            int result = calc.GetLargestValue(numbers);

            // Assert
            Assert.AreEqual(0, result);
        }

    }
}
