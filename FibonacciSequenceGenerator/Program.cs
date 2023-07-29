using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        Fibonacci(terms);
    }

    static void Fibonacci(int terms)
    {
        long number1 = 0, number2 = 1, nextNumber;

        if (terms < 1)
        {
            Console.WriteLine("Please enter a positive integer.");
        }
        else if (terms == 1)
        {
            Console.WriteLine("Fibonacci sequence upto " + terms + " term: ");
            Console.WriteLine(number1);
        }
        else
        {
            Console.WriteLine("Fibonacci sequence upto " + terms + " terms: ");
            Console.Write(number1 + ", " + number2 + ", ");
            for (int i = 3; i <= terms; i++)
            {
                nextNumber = number1 + number2;
                Console.Write(nextNumber + ", ");
                number1 = number2;
                number2 = nextNumber;
            }
        }
    }
}
