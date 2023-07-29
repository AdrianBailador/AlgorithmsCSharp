using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

        string reversedArrayString = GetReversedArrayString(arr);
        Console.WriteLine(reversedArrayString);
    }

    static string GetReversedArrayString(int[] arr)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            sb.Append(arr[i]);
            if (i > 0)
            {
                sb.Append(" ");
            }
        }

        return sb.ToString();
    }
}
