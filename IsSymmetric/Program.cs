using System;

public class Program
{
    public static void Main()
    {
        const int origin = 56543325;
        bool isSymmetric = IsSymmetric(origin);

        Console.WriteLine(isSymmetric ? "Is Symmetric" : "Is Asymmetric");
    }

    static bool IsSymmetric(int num)
    {
        int rev = 0;
        int origin = num;
        while (num > 0)
        {
            rev = rev * 10 + num % 10;
            num /= 10;
        }

        return origin == rev;
    }
}
