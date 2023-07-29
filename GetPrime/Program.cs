using System;

public class Program
{
    public static void Main()
    {
        int num = 899754321;
        PrintPrimeDigits(num);
    }

    private static void PrintPrimeDigits(int num)
    {
        var result = "";
        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;

            if (IsPrimeDigit(digit))
            {
                result = $"{digit}, " + result;
            }
        }
        Console.WriteLine(result.TrimEnd(' ', ','));
    }

    private static bool IsPrimeDigit(int digit)
    {
        return digit == 2 || digit == 3 || digit == 5 || digit == 7;
    }
}
