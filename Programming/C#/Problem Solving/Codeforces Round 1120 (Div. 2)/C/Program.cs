
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (arr.Contains(0))
    {
        Console.WriteLine(n - 1);
        for (int i = 1; i <= n - 1; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    else
    {
        if(n % 2 == 0)
        {
            Console.WriteLine(2);
            Console.WriteLine("0 2");
        }
        else
        {
            Console.WriteLine(2);
            Console.WriteLine("0 1");
        }
    }
}