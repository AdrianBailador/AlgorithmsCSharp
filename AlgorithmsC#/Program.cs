using System;

public class Program
{
    private static readonly Random Random = new Random();

    public static void Main()
    {
        int[] array = CreateArray();
        PrintArray(array);
        (int index, int attempts) = FindOne(array);
        Console.WriteLine($"Index: {index}, Attempts: {attempts}");
    }

    private static int[] CreateArray()
    {
        int[] array = new int[100];
        int randomIndex = Random.Next(0, 100);
        array[randomIndex] = 1;
        return array;
    }

    private static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            if (value == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write(value);
            Console.ResetColor();
        }
        Console.WriteLine();
        Console.WriteLine($"Array Length: {array.Length}");
    }

    private static (int, int) FindOne(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;
        int attempts = 0;

        while (left <= right)
        {
            attempts++;
            int mid = left + (right - left) / 2;
            if (array[mid] == 1)
            {
                return (mid, attempts);
            }
            if (array[mid] < 1)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return (-1, attempts);
    }
}
