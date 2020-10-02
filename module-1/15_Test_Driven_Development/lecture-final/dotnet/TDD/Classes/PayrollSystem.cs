using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD.Classes
{
    /// <summary>
    /// This class is responsible for tracking employees and their pay
    /// </summary>
    public class PayrollSystem
    {
        private Dictionary<string, double> employeeSalaries 
            = new Dictionary<string, double>();

        public bool HireEmployee(string name, double salary)
        {
            this.employeeSalaries[name] = salary;

            TotalPayroll += salary;

            return true;
        }

        public void FireEmployee(string name)
        {
            if (this.employeeSalaries.ContainsKey(name))
            {
                this.TotalPayroll -= this.employeeSalaries[name];
                this.employeeSalaries.Remove(name);
            }
        }

        public double TotalPayroll { get; private set; }

        public string[] Employees
        {
            get
            {
                return this.employeeSalaries.Keys.ToArray();
            }
        }
    }
}
