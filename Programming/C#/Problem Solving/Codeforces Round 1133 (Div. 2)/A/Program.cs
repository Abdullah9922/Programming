
int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    var b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (k % 2 == 0)
    {
        Console.WriteLine(a.Count(x => x == 0) <= b.Count(x => x == 0) ? "YES" : "NO");
    }
    else
    {
        Console.WriteLine(b.Count(x => x == 0) <= a.Count(x => x == 0) ? "YES" : "NO");
    }
}