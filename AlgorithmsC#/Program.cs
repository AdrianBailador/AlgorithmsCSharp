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
        // Binary search needs a sorted array, but only one random position holds a 1
        // amid a sea of 0s, so the array isn't ordered. A linear scan is the correct
        // approach here.
        int attempts = 0;

        for (int i = 0; i < array.Length; i++)
        {
            attempts++;
            if (array[i] == 1)
            {
                return (i, attempts);
            }
        }

        return (-1, attempts);
    }
}
