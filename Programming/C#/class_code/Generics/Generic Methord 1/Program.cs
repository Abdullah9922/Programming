using System.Runtime.CompilerServices;

public class Test
{
    public static void print(int[] numbers)
    {
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }

    public static void print(string[] names)
    {
        foreach (string i in names)
        {
            Console.WriteLine(i);
        }
    }


    public static void Display<A>(A[] names)
    {
        foreach (A i in names)
        {
            Console.WriteLine(i);
        }
    }

    public static bool check<B> (B a,B b)
    {
        bool c = a.Equals(b);
        return c;
    }

    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4 };
        Test.print(numbers);

        string[] names = { "Korim", "Joim", "Rohim" };
        Test.print(names);

        Console.WriteLine();
        Test.Display<int>(numbers);
        Test.Display<string>(names);
        Console.WriteLine();

        Console.WriteLine(Test.check(2,2));
        Console.WriteLine(Test.check("ali", "alic"));
    }
}