using System;
using System.Collections.Generic;

namespace MyAlgorithms
{
    public static class DataTypeChecker
    {
        private static readonly Dictionary<string, (int size, dynamic min, dynamic max)> Types = new()
        {
            { "bool", (sizeof(bool), bool.FalseString, bool.TrueString) },
            { "byte", (sizeof(byte), byte.MinValue, byte.MaxValue) },
            { "sbyte", (sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue) },
            { "char", (sizeof(char), char.MinValue, char.MaxValue) },
            { "short", (sizeof(short), short.MinValue, short.MaxValue) },
            { "ushort", (sizeof(ushort), ushort.MinValue, ushort.MaxValue) },
            { "int", (sizeof(int), int.MinValue, int.MaxValue) },
            { "uint", (sizeof(uint), uint.MinValue, uint.MaxValue) },
            { "long", (sizeof(long), long.MinValue, long.MaxValue) },
            { "ulong", (sizeof(ulong), ulong.MinValue, ulong.MaxValue) },
            { "float", (sizeof(float), float.MinValue, float.MaxValue) },
            { "double", (sizeof(double), double.MinValue, double.MaxValue) },
            { "decimal", (sizeof(decimal), decimal.MinValue, decimal.MaxValue) }
        };

        public static void CheckDataType()
        {
            while (true)
            {
                string input = GetUserInput();

                if (input == "exit")
                {
                    break;
                }
                else
                {
                    PrintDataTypeDetails(input);
                }
            }
        }

        private static string GetUserInput()
        {
            Console.Write(">> Enter the name of a data type (e.g. int, float, double) or 'exit' to quit: ");
            return Console.ReadLine()?.ToLower() ?? "";
        }

        private static void PrintDataTypeDetails(string input)
        {
            if (Types.ContainsKey(input))
            {
                (int size, dynamic min, dynamic max) = Types[input];
                Console.WriteLine($"Memory size: {size} bytes\nMinimum value: {min}\nMaximum value: {max}");
            }
            else
            {
                Console.WriteLine("Invalid data type name.");
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            DataTypeChecker.CheckDataType();
        }
    }
}
