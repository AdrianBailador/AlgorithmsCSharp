using System;

public class Program
{
    public static void Main()
    {
        int num = 757757574;
        int reversedNumber = ReverseNumber(num);
        Console.WriteLine(reversedNumber);
    }

    static int ReverseNumber(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }
        return reversed;
    }
}
