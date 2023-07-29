using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] arr = { 15, 23, 36, 17, 18 };
        PrintArray(arr);
        Console.WriteLine();

        Console.WriteLine($"Summary: {CalculateSum(arr)}");
        Console.WriteLine($"Average: {CalculateAverage(arr)}");
        Console.WriteLine($"Max: {FindMax(arr)}");
        Console.WriteLine($"Min: {FindMin(arr)}");
        Console.WriteLine($"Max Even: {FindMaxEven(arr)}");
        Console.WriteLine($"Max Odd: {FindMaxOdd(arr)}");
    }

    private static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine();
    }

    private static int CalculateSum(int[] array)
    {
        return array.Sum();
    }

    private static double CalculateAverage(int[] array)
    {
        return array.Average();
    }

    private static int FindMax(int[] array)
    {
        return array.Max();
    }

    private static int FindMin(int[] array)
    {
        return array.Min();
    }

    private static int FindMaxEven(int[] array)
    {
        return array.Where(n => n % 2 == 0).DefaultIfEmpty().Max();
    }

    private static int FindMaxOdd(int[] array)
    {
        return array.Where(n => n % 2 != 0).DefaultIfEmpty().Max();
    }
}
