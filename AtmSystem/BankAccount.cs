public abstract class BankAccount
{
    protected decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public virtual void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public virtual void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
