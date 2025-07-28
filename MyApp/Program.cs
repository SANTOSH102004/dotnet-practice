using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        string? input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        int number;
        if (int.TryParse(input, out number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is even.");
            }
            else
            {
                Console.WriteLine($"{number} is odd.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
       
    }   
}