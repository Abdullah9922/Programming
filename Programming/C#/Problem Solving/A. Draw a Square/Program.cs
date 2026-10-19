
int tc = int.Parse(Console.ReadLine());

int l, r, d, u;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    l = int.Parse(input[0]);
    r = int.Parse(input[1]);
    d = int.Parse(input[2]);
    u = int.Parse(input[3]);

    if (l == r && r == d && d == u && l == u) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}