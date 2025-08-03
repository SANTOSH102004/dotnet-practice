class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ATM Simulation!");
        SavingsAccount account = new SavingsAccount(1000); // Initial balance: 1000
        ATM atm = new ATM(account);
        atm.ShowMenu();
    }
}
