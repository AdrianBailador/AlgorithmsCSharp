using System;

public class Program
{
    private delegate int Operation(int a, int b);

    public static void Main()
    {
        Operation add = Add;
        Operation subtract = Subtract;
        Operation multiply = (a, b) => a * b;

        Invoke(add, 5, 3);
        Invoke(subtract, 5, 3);
        Invoke(multiply, 5, 3);
    }

    private static int Add(int a, int b) => a + b;

    private static int Subtract(int a, int b) => a - b;

    private static void Invoke(Operation operation, int a, int b)
    {
        int result = operation(a, b);
        Console.WriteLine($"{operation.Method.Name}({a}, {b}) = {result}");
    }
}
