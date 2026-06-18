class Test
{

    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine($"{Sum(10, 20)}");
        Console.WriteLine($"{Sum(10, 20, 30)}");
        Console.WriteLine($"{Sum(10, 20, 30, 40)}");
        Console.WriteLine($"{Sum(10, 20, 1)}");
    }
}