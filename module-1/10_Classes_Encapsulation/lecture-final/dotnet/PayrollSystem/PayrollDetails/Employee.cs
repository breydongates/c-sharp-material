using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.PayrollDetails
{
    public class Employee
    {
        private decimal totalIncome;
        private string firstName = "John";
        private string lastName = "Doe";
        private int timesEdited;

        public Employee(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; }

        public decimal Salary { get; set; }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.firstName = value;
                }

                this.timesEdited++;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.lastName = value;
                }
            }
        }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public void Pay()
        {
            Console.WriteLine("It is payday for " + this.FullName);
            // this.totalIncome += this.Salary / 26.0M;
            this.Pay(this.Salary / 26.0M);
        }

        public decimal Pay(decimal amount)
        {
            decimal amountToDeduct = Employee.CalculateWithholdingAmount(amount);

            this.totalIncome += amount - amountToDeduct;

            return this.totalIncome;
        }

        private static decimal CalculateWithholdingAmount(decimal amount)
        {
            return amount * 0.05M;
        }

        /* Cannot do this
        public void Pay(decimal amount)
        {
            this.totalIncome += amount;

            return this.totalIncome;
        }
        */
    }
}
