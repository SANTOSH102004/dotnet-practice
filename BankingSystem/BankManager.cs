public class BankManager
{
    private List<Account> accounts = new List<Account>();

    public void CreateAccount()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Account Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Initial Deposit: ₹");
        double balance = double.Parse(Console.ReadLine());

        Console.Write("Account Type (1. Savings | 2. Current): ");
        string type = Console.ReadLine();

        Account acc = null;
        if (type == "1")
            acc = new SavingsAccount(name, number, balance);
        else if (type == "2")
            acc = new CurrentAccount(name, number, balance);

        if (acc != null)
        {
            accounts.Add(acc);
            Console.WriteLine("✅ Account Created!");
        }
    }

    public Account? FindAccount(int number)
    {
        return accounts.FirstOrDefault(a => a.GetAccountNumber() == number);
    }

    public void ShowAllAccounts()
    {
        foreach (var acc in accounts)
        {
            acc.DisplayDetails();
        }
    }
}
