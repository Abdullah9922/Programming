
public delegate void Calculation(int a, int b);

public class Test
{
    public static void Addition(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("Addition reuslt is: {0}", reuslt);
    }

    public static void Subtraction(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("Subtraction reuslt is: {0}", reuslt);
    }

    public static void Multipliction(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("Multipliction reuslt is: {0}", reuslt);
    }

    public static void Divition(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("Divition reuslt is: {0}", reuslt);
    }

    public static void Main(string[] args)
    {
        Calculation obj = new Calculation(Addition);
        obj += Subtraction;
        obj += Multipliction;
        obj -= Divition;

        obj(30, 2);


        Console.ReadKey();
    }
}

