public class CurrentAccount : Account
{
    private const double overdraftLimit = -10000;

    public CurrentAccount(string name, int number, double balance)
        : base(name, number, balance) { }

    public override void Withdraw(double amount)
    {
        if (balance - amount >= overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn ₹{amount}");
        }
        else
        {
            Console.WriteLine("❌ Overdraft limit reached!");
        }
    }

    public override void DisplayDetails()
    {
        Console.WriteLine($"[Current Account] {GetAccountHolder()}, Acc No: {GetAccountNumber()}, Balance: ₹{GetBalance()}");
    }
}
