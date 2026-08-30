using System;

public class Program
{
    public static void Main()
    {
        int number = GetNumberInRange(1, 100);
        Console.WriteLine($"Random number: {number}");
    }

    private static int GetNumberInRange(int min, int max)
    {
        Random random = new();
        return random.Next(min, max + 1);
    }
}
