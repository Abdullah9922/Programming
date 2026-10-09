
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    if (n % 2 == 0) Console.WriteLine(-1);
    else
    {
        Console.Write(n);
        for(int i=1; i<=n-1; i++)
        {
            Console.Write(" " + i );
        }
        Console.WriteLine();
    }
}