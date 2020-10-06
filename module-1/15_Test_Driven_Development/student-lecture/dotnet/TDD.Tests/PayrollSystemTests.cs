using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDD.Classes;

namespace TDD.Tests
{
    [TestClass]
    public class PayrollSystemTests
    {
        // Our requirements:

        // 0. We can create a payroll system
        [TestMethod]
        public void PayrollSystemShouldInitializeCorrectly()
        {
            // Arrange
            PayrollSystem system = new PayrollSystem();

            // Act
            // Act is the act of creating the system in arrange

            // Assert
            Assert.IsNotNull(system);
            Assert.AreEqual(0, system.TotalPayroll);
        }

        // 1. HireEmployee should accept a name and salary and return true
        [TestMethod]
        public void HireEmployeeShouldSucceed()
        {
            // Arrange
            PayrollSystem system = new PayrollSystem();

            // Act
            bool result = system.HireEmployee("Bruce Wayne", 75000);

            // Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("John Fulton", 1000000)]
        [DataRow("Matt Eland", 0)]
        public void TotalPayrollReflectsHiredEmployee(string name, double salary)
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee(name, salary);

            //act
            double result = system.TotalPayroll;

            //assert
            Assert.AreEqual(salary, result);
        }
        // 3. fire emloyee should accept a name and remove that employee

        [TestMethod]
        public void FireEmployeeShouldReduceSalary()
        {
            //Arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Big Head", 42000);

            //act
            system.FireEmployee("Big Head");

            //assert
            Assert.AreEqual(0, system.TotalPayroll);
        }
        [TestMethod]
        public void FireEmployeeShouldDoNothingWithNonEmployees()
        {
            //Arrange
            PayrollSystem system = new PayrollSystem();
          

            //act
            system.FireEmployee("Big Head");

            //assert
            Assert.AreEqual(0, system.TotalPayroll);
        }

        //4. employees property should return the names of all employees

        [TestMethod]
        public void EmployeesShouldListAllEmployees()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Bruce Banner", 75000);
            system.HireEmployee("Peter Parker", 50000);
            string[] expected = { "Bruce Banner", "Peter Parker" };
            //act
            string[] result = system.Employees;

            //assert
            Assert.AreEqual(2, result.Length);
            CollectionAssert.AreEquivalent(expected, result); // order doesnt matter in areequivilant 
        }

        [TestMethod]
        public void EmployeesShouldNotBeEmployeesAfterBeingFired()
        {
            //arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Milton", 35000);

            //act
            system.FireEmployee("Milton");
            string[] employees = system.Employees;
            //assert

            CollectionAssert.DoesNotContain(system.Employees, "Milton");



        }

        //5. GiveRaise should increase all current employee salaries by a 
    }
}



