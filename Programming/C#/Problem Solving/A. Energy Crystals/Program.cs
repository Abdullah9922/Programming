
int tc = int.Parse(Console.ReadLine());

long x;
while (tc-- > 0)
{
    x = long.Parse(Console.ReadLine());

    int a1 = 0, a2 = 0, a3 = 0;
    int ans = 0;

    while (Math.Min(a1, Math.Min(a2, a3)) < x)
    {
        if (a1 <= a2 && a1 <= a3)
        {
            a1 = Math.Min(a2, a3) * 2 + 1;
        }
        else if (a2 <= a1 && a2 <= a3)
        {
            a2 = Math.Min(a1, a3) * 2 + 1;
        }
        else
        {
            a3 = Math.Min(a1, a2) * 2 + 1;
        }

        ans++;
    }

    Console.WriteLine(ans);
}
