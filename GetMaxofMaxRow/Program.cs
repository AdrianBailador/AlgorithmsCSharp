using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 54234, 53131, 599657588, 513123, 77567, 12123123, 33234, 232131 };

        int maxIndex = FindMaxIndex(arr);
        int maxDigit = FindMaxDigit(arr[maxIndex]);

        Console.WriteLine($"Max Number: {maxDigit}, Index: {maxIndex}");
    }

    private static int FindMaxIndex(int[] array)
    {
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[maxIndex] < array[i])
            {
                maxIndex = i;
            }
        }
        return maxIndex;
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
