using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.PayrollDetails
{
    public class Company
    {
        private List<Employee> employees = new List<Employee>();

        public Company(string name, string address)
        {
            this.Name = name;
            this.Address = address;
            this.WirelessPassword = "Password1";
        }

        public string Name { get; }

        public string Address { get; set; }

        public string WirelessPassword { get; private set; } // = "Password1"

        public void Hire(Employee employee, decimal startingSalary)
        {
            employee.Salary = startingSalary;

            employees.Add(employee);
        }

        public void Pay()
        {
            foreach (Employee emp in this.employees)
            {
                emp.Pay();
            }
        }
    }
}
