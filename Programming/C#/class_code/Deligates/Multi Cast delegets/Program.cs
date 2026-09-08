
public delegate void Calculation(int a, int b);

public class Test
{
    public static void Addition(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("1111111111 Addition reuslt is: {0}", reuslt);
    }

    public static void Subtraction(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("22222222222 Subtraction reuslt is: {0}", reuslt);
    }

    public static void Multipliction(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("333333333333 Multipliction reuslt is: {0}", reuslt);
    }

    public static void Divition(int num1, int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("444444444444 Divition reuslt is: {0}", reuslt);
    }

    public static void Main(string[] args)
    {
        Calculation obj = new Calculation(Addition);
        //obj += Subtraction;
        obj += Multipliction;
        obj -= Divition;
        obj -= Subtraction;
        obj += Subtraction;

        obj(30, 2);


        Console.ReadKey();
    }
}

