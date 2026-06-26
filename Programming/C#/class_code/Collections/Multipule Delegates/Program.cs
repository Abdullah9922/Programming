
// use delegates can write optimize our code in big project
public delegate void Calculation(int a, int b);
public delegate void showDelegate();
public delegate void Calculation2(int a);

public class Test
{

    public static void Square(int num)
    {
        int s = num * num;
        Console.WriteLine("Square of {0} is : {1}", num,s);
    }

    public static void Cube(int num)
    {
        int s = num * num * num;
        Console.WriteLine("Cube of {0} is : {1}", num, s);
    }


    public static void show()
    {
        Console.WriteLine("Showing delegates");
    }

    public static void Addition(int a, int b)
    {
        int r = a + b;
        Console.WriteLine("Addition result is: {0}", r);
    }

    public static void Subtraction(int a, int b)
    {
        int r = a - b;
        Console.WriteLine("Subtraction result is: {0}", r);
    }

    public static void Multiplication(int a, int b)
    {
        int r = a * b;
        Console.WriteLine("Multiplication result is: {0}", r);
    }

    public static void Main(string[] args)
    {
        Calculation obj = new Calculation(Test.Addition);
        obj.Invoke(20, 10);

        obj = Subtraction;
        obj(20, 10);

        obj = Multiplication;
        obj(20, 10);


        Calculation obj2 = new Calculation(Test.Subtraction);
        obj2(2, 4);

        Calculation obj3 = new Calculation(Test.Multiplication);
        obj3(2, 4);


        showDelegate s = new showDelegate(show);
        s.Invoke();

        Calculation2 sq = new Calculation2(Square);
        sq(4);

        Calculation2 cube = new Calculation2(Cube);
        cube(4);

        Console.ReadKey();
    }
}
