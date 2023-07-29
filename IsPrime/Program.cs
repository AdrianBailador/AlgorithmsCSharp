using System;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            RunPrimeChecker();
        }
    }

    static void RunPrimeChecker()
    {
        try
        {
            int number = GetPositiveIntegerFromUser();
            bool isPrime = IsPrime(number);
            Console.WriteLine($"{number} is {(isPrime ? "" : "NOT ")}a prime number.\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}\n");
        }
    }

    static int GetPositiveIntegerFromUser()
    {
        Console.Write("Enter a positive integer: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number) && number > 0)
        {
            return number;
        }

        throw new ArgumentException("Invalid input. Please enter a positive integer.");
    }

    static bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number is 2 or 3) return true;
        if (number % 2 == 0 || number % 3 == 0) return false;

        int sqrtNumber = (int)Math.Sqrt(number);
        for (int i = 5; i <= sqrtNumber; i += 6)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }
}
