
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var p = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    List<int> bad = new List<int>();

    for (int i = 0; i < n; i++)
    {
        if (p[i] != i + 1)
        {
            bad.Add(i);
        }
    }

    bool ok = true;

    int k = bad.Count;

    for (int i = 0; i < k; i++)
    {
        if (p[bad[i]] != bad[k - 1 - i] + 1)
        {
            ok = false;
            break;
        }
    }

    Console.WriteLine(ok ? "YES" : "NO");
}