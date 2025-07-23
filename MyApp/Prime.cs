using System;

class Prime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number :");
        string input = Console.ReadLine();

        int number;
        if (int.TryParse(input, out number))
        {
            if (IsPrime(number))
            {
                Console.WriteLine($"{number} is Prime.");
            }
            else
            {
                Console.WriteLine($"{number} is NOT Prime.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
    }

    static bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }
}
