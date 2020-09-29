using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class CreditCardAccount : IAccountable
    {
        public int Balance { get; set; }
        public CreditCardAccount (string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }
        public string AccountHolderName { get; }

        public string AccountNumber { get; }

        public int Debt 
        {
            get
            { return Balance * -1; }
        }

        public int Pay(int amountToPay)
        {
            Balance = amountToPay - Balance;
            return Balance;
        }

        public int Charge(int amountToCharge)
        {
            Balance = Balance - amountToCharge;
            return Balance;
        }

    }
}
