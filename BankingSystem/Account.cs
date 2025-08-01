public abstract class Account
{
    private string accountHolder;
    private int accountNumber;
    protected double balance;

    public Account(string name, int number, double initialBalance)
    {
        accountHolder = name;
        accountNumber = number;
        balance = initialBalance;
    }

    public string GetAccountHolder() => accountHolder;
    public int GetAccountNumber() => accountNumber;
    public double GetBalance() => balance;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited ₹{amount}");
    }

    public abstract void Withdraw(double amount);
    public abstract void DisplayDetails();
}
