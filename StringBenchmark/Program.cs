using System;
using System.Diagnostics;
using System.Text;

public class Program
{
    const int MaxIterations = 100000;

    static void Main()
    {
        TimeAction("String+String", () =>
        {
            string text = "s";
            for (int i = 0; i < MaxIterations; i++) text += i;
        });

        TimeAction("String.Concat()", () =>
        {
            string text = "s";
            for (int i = 0; i < MaxIterations; i++) text = string.Concat(text, i);
        });

        TimeAction("StringBuilder.Append()", () =>
        {
            StringBuilder text = new StringBuilder("b");
            for (int i = 0; i < MaxIterations; i++) text.Append(i);
        });
    }

    static void TimeAction(string description, Action action)
    {
        Console.WriteLine($"{description} {MaxIterations} times");

        Stopwatch stopwatch = new();
        stopwatch.Start();
        action();
        stopwatch.Stop();

        Console.WriteLine($"Time: {stopwatch.Elapsed}\r\n");
    }
}
