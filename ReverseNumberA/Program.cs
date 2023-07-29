using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        int num = 656565845;
        Console.WriteLine(GetReversedNumber(num));
    }

    static string GetReversedNumber(int num)
    {
        StringBuilder reversedNumber = new StringBuilder();

        while (num > 0)
        {
            int digit = num % 10;
            num /= 10;

            reversedNumber.Append(digit);
        }

        return reversedNumber.ToString();
    }
}
