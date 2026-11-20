
int tc = int.Parse(Console.ReadLine());
while (tc-- > 0)
{

    int n = int.Parse(Console.ReadLine()!);

    HashSet<int> sa = new();
    HashSet<int> sb = new();

    int[] a = new int[n + 1];
    int[] b = new int[n + 1];

    int[] inputA = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
    int[] inputB = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    for (int i = 1; i <= n; i++)
    {
        a[i] = inputA[i - 1];
        sa.Add(a[i]);
    }

    for (int i = 1; i <= n; i++)
    {
        b[i] = inputB[i - 1];
        sb.Add(b[i]);
    }

    Console.WriteLine(sa.Count + sb.Count < 4 ? "NO" : "YES");
}