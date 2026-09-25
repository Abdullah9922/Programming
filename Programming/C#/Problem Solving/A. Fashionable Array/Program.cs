int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    Array.Sort(x);

    if (x[0] % 2 == x[n - 1] % 2)
    {
        Console.WriteLine(0);
        continue;
    }

    int left = n;
    int right = n;

    for (int i = 1; i < n; ++i)
    {
        if (x[i] % 2 != x[0] % 2)
        {
            left = i;
            break;
        }
    }

    for (int i = 1; i < n; ++i)
    {
        if (x[n - i - 1] % 2 != x[n - 1] % 2)
        {
            right = i;
            break;
        }
    }

    Console.WriteLine(Math.Min(left, right));
}
