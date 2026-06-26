
public delegate void Calculation(int a, int b) ;

public class Test
{
    public static void Addition ( int num1 , int num2)
    {
        int reuslt = num1 + num2;
        Console.WriteLine("Addition reuslt is: {0}", reuslt);
    }

    public static void Main(string[] args)
    {
        Calculation obj = new Calculation(Addition);
        obj(30, 20);




        Console.ReadKey();
    }
}
