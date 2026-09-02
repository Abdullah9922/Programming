
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    HashSet<int> s = new HashSet<int>(arr);

    s.Remove(-1);

    if (s.Count <= 1 && !s.Contains(0))
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}
