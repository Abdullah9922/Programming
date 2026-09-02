int tc = int.Parse(Console.ReadLine());

int a, b, c, d;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
    c = int.Parse(input[2]);
    d = int.Parse(input[3]);

    c = c - a;
    d = d - b;
    if (Math.Max(a , b)  <= 2*(Math.Min(a,b)+1) && Math.Max(c, d) <= 2 * (Math.Min(c, d) + 1))
        Console.WriteLine("YES");
    else Console.WriteLine("NO");
}