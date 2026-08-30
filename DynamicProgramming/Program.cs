using System;
using System.Collections.Generic;

namespace DynamicProgrammingAlgorithm
{
    public static class Fibonacci
    {
        public static long Memoized(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException(nameof(n));
            return Compute(n, new Dictionary<int, long>());
        }

        private static long Compute(int n, Dictionary<int, long> cache)
        {
            if (n <= 1) return n;
            if (cache.TryGetValue(n, out long cached)) return cached;

            long result = Compute(n - 1, cache) + Compute(n - 2, cache);
            cache[n] = result;
            return result;
        }
    }

    public static class Knapsack
    {
        // 0/1 knapsack: pick a subset of items (each used at most once) that
        // maximizes total value without the total weight exceeding capacity.
        public static int MaxValue(int[] weights, int[] values, int capacity)
        {
            if (weights.Length != values.Length)
                throw new ArgumentException("weights and values must have the same length.");

            int n = weights.Length;
            int[,] dp = new int[n + 1, capacity + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int w = 0; w <= capacity; w++)
                {
                    dp[i, w] = dp[i - 1, w];

                    if (weights[i - 1] <= w)
                    {
                        int withItem = dp[i - 1, w - weights[i - 1]] + values[i - 1];
                        if (withItem > dp[i, w]) dp[i, w] = withItem;
                    }
                }
            }

            return dp[n, capacity];
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Fibonacci (memoized):");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{Fibonacci.Memoized(i)} ");
            }
            Console.WriteLine();

            int[] weights = { 2, 3, 4, 5 };
            int[] values = { 3, 4, 5, 6 };
            int capacity = 5;

            int maxValue = Knapsack.MaxValue(weights, values, capacity);
            Console.WriteLine($"\n0/1 Knapsack (capacity {capacity}): max value = {maxValue}");
        }
    }
}
