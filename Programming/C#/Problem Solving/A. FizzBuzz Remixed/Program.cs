
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());


    int ans = 3 * (n / 15);
    n %= 15;

    for (int j = 0; j <= n; j++)
    {
        if (j % 3 == j % 5)
        {
            ans++;
        }
    }

    Console.WriteLine(ans);
}

