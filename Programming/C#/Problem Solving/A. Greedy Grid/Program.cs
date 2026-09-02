int tc = int.Parse(Console.ReadLine());

int n, m;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    m = int.Parse(input[1]);

    if (n == 1 || m == 1 || (n == 2 && m == 2)) Console.WriteLine("NO");
    else Console.WriteLine("YES");
}
