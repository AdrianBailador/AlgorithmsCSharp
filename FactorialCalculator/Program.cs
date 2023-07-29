using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factorial of " + num + " (iterative): " + FactorialIterative(num));
        Console.WriteLine("Factorial of " + num + " (recursive): " + FactorialRecursive(num));
    }

    // Iterative approach
    static long FactorialIterative(int num)
    {
        long result = 1;
        for (int i = 1; i <= num; i++)
        {
            result *= i;
        }
        return result;
    }

    // Recursive approach
    static long FactorialRecursive(int num)
    {
        if (num == 0) return 1;
        return num * FactorialRecursive(num - 1);
    }
}
