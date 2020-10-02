using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDD.Tests
{
    [TestClass]
    public class PayrollSystemTests
    {
        // Our requirements:

        // 0. We can create a payroll system

        // 1. HireEmployee should accept a name and salary and return true

        // 2. A TotalPayroll property which gives us the current total pay

        // 3. FireEmployee should accept a name and remove that employee from the organization(TotalPayroll should no longer include them)

        // 4. Employees property should return the names of all current employees

        // 5. GiveRaise should increase all current employees salaries by a specific %

    }
}
