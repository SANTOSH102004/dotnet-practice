class Program
{
    static void Main()
    {
        BankManager bank = new BankManager();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n====== BANK MENU ======");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Show All Accounts");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    bank.CreateAccount();
                    break;

                case "2":
                    Console.Write("Enter Account Number: ");
                    int depNum = int.Parse(Console.ReadLine());
                    var acc1 = bank.FindAccount(depNum);
                    if (acc1 != null)
                    {
                        Console.Write("Enter Amount: ₹");
                        double amt = double.Parse(Console.ReadLine());
                        acc1.Deposit(amt);
                    }
                    else Console.WriteLine("❌ Account not found.");
                    break;

                case "3":
                    Console.Write("Enter Account Number: ");
                    int withNum = int.Parse(Console.ReadLine());
                    var acc2 = bank.FindAccount(withNum);
                    if (acc2 != null)
                    {
                        Console.Write("Enter Amount: ₹");
                        double amt = double.Parse(Console.ReadLine());
                        acc2.Withdraw(amt);
                    }
                    else Console.WriteLine("❌ Account not found.");
                    break;

                case "4":
                    Console.Write("Enter Account Number: ");
                    int balNum = int.Parse(Console.ReadLine());
                    var acc3 = bank.FindAccount(balNum);
                    if (acc3 != null)
                        Console.WriteLine($"Balance: ₹{acc3.GetBalance()}");
                    else
                        Console.WriteLine("❌ Account not found.");
                    break;

                case "5":
                    bank.ShowAllAccounts();
                    break;

                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("❌ Invalid option");
                    break;
            }
        }
    }
}
