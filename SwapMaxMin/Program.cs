using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 3, 1, 6, 4 };
        SwapMaxMin(arr);

        foreach (int i in arr)
            Console.Write(i + "  ");
    }

    static void SwapMaxMin(int[] arr)
    {
        int max = arr[0], min = arr[0], maxIndex = 0, minIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (max < arr[i])
            {
                max = arr[i];
                maxIndex = i;
            }
            else if (min > arr[i])
            {
                min = arr[i];
                minIndex = i;
            }
        }

        arr[maxIndex] = min;
        arr[minIndex] = max;
    }
}
