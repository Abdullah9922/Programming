
int tc = int.Parse(Console.ReadLine());

int n, m, p, q;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    m = int.Parse(input[1]);
    p = int.Parse(input[2]);
    q = int.Parse(input[3]);

    if (n % p == 0 && (n / p) * q != m)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}