
int tc = int.Parse(Console.ReadLine());

int n, m;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    m = int.Parse(input[1]);

    int[] x = new int[n];
    int[] y = new int[n];

    for (int i = 0; i < n; i++)
    {
        input = Console.ReadLine().Split();
        x[i] = int.Parse(input[0]);
        y[i] = int.Parse(input[1]);
    }

    int ans = 2 * (
        x.Sum() + m - x[0] +
        y.Sum() + m - y[0]
    );

    Console.WriteLine(ans);
}