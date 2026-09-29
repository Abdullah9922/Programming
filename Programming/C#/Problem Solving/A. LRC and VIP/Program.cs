
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int mn = a.Min();
    int mx = a.Max();

    if (mn == mx)
    {
        Console.WriteLine("No");
        continue;
    }

    Console.WriteLine("Yes");

    for (int i = 0; i < n; i++)
    {
        Console.Write(1 + (a[i] == mx ? 1 : 0));

        if (i + 1 == n)
            Console.WriteLine();
        else
            Console.Write(" ");
    }
}