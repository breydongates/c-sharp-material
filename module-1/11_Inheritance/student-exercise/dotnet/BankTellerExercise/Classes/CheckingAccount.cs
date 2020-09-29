namespace BankTellerExercise.Classes
{

    public class CheckingAccount : BankAccount
    {

        public CheckingAccount (string accountHolderName, string accountNumber): base (accountHolderName,accountNumber)
        {

        }
        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance):base ( accountHolderName, accountNumber, balance)
        {


        }
        public override decimal Withdraw(decimal amountToWithdraw)
        {

          if (Balance - amountToWithdraw <= 0 && Balance - amountToWithdraw >= -90)
            {
                base.Withdraw(amountToWithdraw + 10);
                return Balance;
            }
               
          else if (Balance - amountToWithdraw >= 0)
            {
                base.Withdraw(amountToWithdraw);
                return Balance;
            }
            return Balance;
        }

    }
}
