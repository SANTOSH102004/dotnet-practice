public class ATM
{
    private SavingsAccount account;

    public ATM(SavingsAccount account)
    {
        this.account = account;
    }

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n------ ATM MENU ------");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Current Balance: {account.GetBalance()}");
                    break;

                case 2:
                    Console.Write("Enter deposit amount: ");
                    decimal deposit = Convert.ToDecimal(Console.ReadLine());
                    account.Deposit(deposit);
                    break;

                case 3:
                    Console.Write("Enter withdrawal amount: ");
                    decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;

                case 4:
                    Console.WriteLine("Thank you for using ATM. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

        } while (choice != 4);
    }
}
