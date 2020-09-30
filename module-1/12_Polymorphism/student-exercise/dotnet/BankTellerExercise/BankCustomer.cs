using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    public class BankCustomer
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        private List<IAccountable> listAccounts = new List<IAccountable>();

        public bool IsVip
        
        { get
            {
                int totalBalance = 0;

                foreach (IAccountable account in listAccounts)
                {
                    totalBalance += account.Balance;

                }
                if(totalBalance >= 25000)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            }
        
        
        }

        public void AddAccount(IAccountable newAccount)
        {
            listAccounts.Add(newAccount);

        }

        public IAccountable[] GetAccounts()
        {
            return listAccounts.ToArray();
        }

    }
}
