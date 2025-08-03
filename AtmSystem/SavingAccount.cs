public class SavingsAccount : BankAccount
{
    public SavingsAccount(decimal initialBalance) : base(initialBalance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Cannot withdraw the amount. Please check balance.");
        }
    }
}
