using System;

public class Program
{
    public static void Main()
    {
        int num = 376543245;
        int maxDigit = FindMaxDigit(num);
        Console.WriteLine(maxDigit);
    }

    private static int FindMaxDigit(int num)
    {
        int maxDigit = 0;
        while (num > 0)
        {
            int currentDigit = num % 10;
            num /= 10;
            if (currentDigit > maxDigit) maxDigit = currentDigit;
        }
        return maxDigit;
    }
}
