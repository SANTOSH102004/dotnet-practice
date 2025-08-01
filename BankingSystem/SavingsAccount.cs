public class SavingsAccount : Account
{
    private const double minBalance = 500;

    public SavingsAccount(string name, int number, double balance)
        : base(name, number, balance) { }

    public override void Withdraw(double amount)
    {
        if (balance - amount >= minBalance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn ₹{amount}");
        }
        else
        {
            Console.WriteLine("❌ Minimum balance ₹500 required.");
        }
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Savings Account] {GetAccountHolder()}, Acc No: {GetAccountNumber()}, Balance: ₹{GetBalance()}");
    }
}
