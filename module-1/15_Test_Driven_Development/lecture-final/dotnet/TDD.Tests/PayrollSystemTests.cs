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

        // 2. A TotalPayroll property which gives us the current total pay
        [TestMethod]
        [DataRow("John Fulton", 1000000)]
        [DataRow("Matt Eland", 0)]
        public void TotalPayrollReflectsHiredEmployee(string name, double salary)
        {
            // Arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee(name, salary);

            // Act
            double result = system.TotalPayroll;

            // Assert
            Assert.AreEqual(salary, result);
        }

        // 3. FireEmployee should accept a name and remove that employee from the organization(TotalPayroll should no longer include them)
        [TestMethod]
        public void FireEmployeeShouldReduceSalary()
        {
            // Arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Big Head", 42000);

            // Act
            system.FireEmployee("Big Head");

            // Assert
            Assert.AreEqual(0, system.TotalPayroll);
        }

        [TestMethod]
        public void FireEmployeeShouldDoNothingWithNonEmployees()
        {
            // Arrange
            PayrollSystem system = new PayrollSystem();

            // Act
            system.FireEmployee("Big Head");

            // Assert
            Assert.AreEqual(0, system.TotalPayroll);
        }

        // 4. Employees property should return the names of all current employees
        [TestMethod]
        public void EmployeesShouldListAllEmployees()
        {
            // Arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Peter Parker", 50000);
            system.HireEmployee("Bruce Banner", 75000);
            string[] expected = { "Bruce Banner", "Peter Parker" };

            // Act
            string[] result = system.Employees;

            // Assert
            Assert.AreEqual(2, result.Length);
            CollectionAssert.AreEquivalent(expected, result);
        }

        [TestMethod]
        public void EmployeesShouldNotBeEmployeesAfterBeingFired()
        {
            // Arrange
            PayrollSystem system = new PayrollSystem();
            system.HireEmployee("Milton", 35000);

            // Act
            system.FireEmployee("Milton");
            string[] employees = system.Employees;

            // Assert
            CollectionAssert.DoesNotContain(employees, "Milton");
            Assert.AreEqual(0, employees.Length);
        }

        // 5. GiveRaise should increase all current employees salaries by a specific %

    }
}
