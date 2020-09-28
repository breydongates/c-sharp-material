using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollSystem.PayrollDetails
{
    public class Company
    {
        public Company(string name, string address)
        {
            this.Name = name;
            this.Address = address;
            this.WirelessPassword = "Password1";
        }

        public string Name { get; }

        public string Address { get; set; }

        public string WirelessPassword { get; private set; } // = "Password1"
    }
}