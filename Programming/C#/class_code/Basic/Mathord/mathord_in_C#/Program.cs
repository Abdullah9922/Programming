using System;

class Program
{
    // 1. No Parameter, No Return Type
    static void Welcome()
    {
        Console.WriteLine("Welcome to C# Methods");
    }

    // 2. Parameter, No Return Type
    static void ShowSquare(int n)
    {
        Console.WriteLine("Square = " + (n * n));
    }

    // 3. No Parameter, Return Type
    static int GetNumber()
    {
        return 10;
    }

    // 4. Parameter, Return Type
    static int FindMax(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static void Main()
    {
        Welcome();

        ShowSquare(7);

        int num = GetNumber();
        Console.WriteLine("Number = " + num);

        int max = FindMax(25, 40);
        Console.WriteLine("Maximum = " + max);
    }
}