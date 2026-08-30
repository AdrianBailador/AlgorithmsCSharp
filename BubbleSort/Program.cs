using System;

namespace SortingAlgorithms
{
    public class Program
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

            arr = new int[] { 64, 34, 25, 12, 22, 11, 90 }; // resetting array

            arr = MergeSort(arr);
            Console.WriteLine("\nSorted array with Merge Sort: ");
            PrintArray(arr);

            arr = new int[] { 64, 34, 25, 12, 22, 11, 90 }; // resetting array

            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array with Quick Sort: ");
            PrintArray(arr);
        }

        static void PrintArray(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static void BubbleSort(int[] arr)
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

        public static void SelectionSort(int[] arr)
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

        public static void InsertionSort(int[] arr)
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

        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            int mid = arr.Length / 2;
            int[] left = MergeSort(arr[..mid]);
            int[] right = MergeSort(arr[mid..]);

            return Merge(left, right);
        }

        static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
                result[k++] = left[i] <= right[j] ? left[i++] : right[j++];

            while (i < left.Length) result[k++] = left[i++];
            while (j < right.Length) result[k++] = right[j++];

            return result;
        }

        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low >= high) return;

            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }
    }
}
