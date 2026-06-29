using System.Diagnostics.CodeAnalysis;

class Program
{
    public static int add(params int[] nums)
    {
        int sum = 0;
        foreach (int i in nums)
        {
            sum += i;
        }

        return sum;                                             
    }

    static void Main(string[] args)
    {
        Console.WriteLine(Program.add(10, 20, 30, 50));
        Console.ReadKey();
    }
}