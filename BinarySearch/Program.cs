using System;

namespace BinarySearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            int result = BinarySearch(arr, 0, arr.Length - 1, x);

            if (result == -1)
                Console.WriteLine("Element not present in array");
            else
                Console.WriteLine("Element found at index " + result);
        }

        static int BinarySearch(int[] arr, int l, int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                // If the element is present at the middle itself
                if (arr[mid] == x)
                    return mid;

                // If element is smaller than mid, then it can only be present in left subarray
                if (arr[mid] > x)
                    return BinarySearch(arr, l, mid - 1, x);

                // Else the element can only be present in right subarray
                return BinarySearch(arr, mid + 1, r, x);
            }

            // We reach here when element is not present in array
            return -1;
        }
    }
}
