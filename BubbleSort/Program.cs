using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original array : ");
            PrintArray(arr);

            BubbleSort(arr);
            Console.WriteLine("\nSorted array with Bubble Sort: ");
            PrintArray(arr);

            arr = new int[] { 64, 34, 25, 12, 22, 11, 90 }; // resetting array

            SelectionSort(arr);
            Console.WriteLine("\nSorted array with Selection Sort: ");
            PrintArray(arr);

            arr = new int[] { 64, 34, 25, 12, 22, 11, 90 }; // resetting array

            InsertionSort(arr);
            Console.WriteLine("\nSorted array with Insertion Sort: ");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        static void BubbleSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                for (int j = 0; j < len - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int min_idx = i;
                for (int j = i + 1; j < len; j++)
                    if (arr[j] < arr[min_idx])
                        min_idx = j;

                // Swap arr[min_idx] and arr[i]
                int temp = arr[min_idx];
                arr[min_idx] = arr[i];
                arr[i] = temp;
            }
        }

        static void InsertionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 1; i < len; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
