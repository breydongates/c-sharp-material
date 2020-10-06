using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TDD.Classes
{
   
    public class PayrollSystem
    {
        private Dictionary<string, double> employeeSalaries = new Dictionary<string, double>();


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
                //this.employeeSalaries[name] = 0;
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
