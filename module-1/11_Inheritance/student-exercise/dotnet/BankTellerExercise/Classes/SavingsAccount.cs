namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {


        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (this.Balance - amountToWithdraw < 150 && this.Balance > amountToWithdraw)
            {
                return base.Withdraw(amountToWithdraw + 2);
            }
            else if (this.Balance >= 150 && this.Balance > amountToWithdraw)
            {
                return base.Withdraw(amountToWithdraw);
            }
            else
            {
                return Balance;
            }

            //return base.Withdraw(amountToWithdraw);
        }
    }
}
