int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    string[] input = Console.ReadLine()!.Split();

    int n = int.Parse(input[0]);
    int m = int.Parse(input[1]);

    int[,] a = new int[n, m];

    for (int i = 0; i < n; i++)
    {
        string s = Console.ReadLine()!;

        for (int j = 0; j < m; j++)
        {
            a[i, j] = s[j] - '0';
        }
    }

    int r = 0, c = 0;

    // Count rows with odd number of 1s
    for (int i = 0; i < n; i++)
    {
        int sum = 0;

        for (int j = 0; j < m; j++)
        {
            sum ^= a[i, j];
        }

        if (sum == 1)
            r++;
    }

    // Count columns with odd number of 1s
    for (int j = 0; j < m; j++)
    {
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum ^= a[i, j];
        }

        if (sum == 1)
            c++;
    }

    Console.WriteLine(Math.Max(r, c));
}