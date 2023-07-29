using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        const int arraySize = 100;
        const int targetValue = 1;

        int[] array = CreateArrayWithRandomTarget(arraySize, targetValue);
        PrintArray(array, targetValue);

        (int index, int attempts) = FindTargetIndexAndAttempts(array, targetValue);

        Console.WriteLine($"\nIndex: {index}, Attempts: {attempts}");
    }

    private static int[] CreateArrayWithRandomTarget(int size, int targetValue)
    {
        int[] array = new int[size];
        Random random = new();

        int randomIndex = random.Next(size);
        array[randomIndex] = targetValue;

        return array;
    }

    private static void PrintArray(IReadOnlyList<int> array, int targetValue)
    {
        foreach (int i in array)
        {
            if (i == targetValue)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(targetValue);
                Console.ResetColor();
            }
            else Console.Write(i);
        }
    }

    private static (int, int) FindTargetIndexAndAttempts(IReadOnlyList<int> array, int targetValue)
    {
        int attempts = 0;
        int count = array.Count;

        for (int i = count / 2; i < count; i++)
        {
            attempts++;
            if (array[i] == targetValue)
            {
                return (i, attempts);
            }
        }
        for (int i = count / 2 - 1; i > 0; i--)
        {
            attempts++;
            if (array[i] == targetValue)
            {
                return (i, attempts);
            }
        }
        return (-1, attempts);
    }
}
