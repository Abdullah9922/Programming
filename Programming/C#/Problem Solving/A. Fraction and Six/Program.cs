
int tc = int.Parse(Console.ReadLine());
int n, m;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    m = int.Parse(input[1]);

    string p = Console.ReadLine();
    string q = Console.ReadLine();

    q += "six";

    int[] pc = new int[255];
    int[] qc = new int[255];

    foreach (char z in p)
        pc[z]++;

    foreach (char z in q)
        qc[z]++;

    if (pc.SequenceEqual(qc))
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");
}