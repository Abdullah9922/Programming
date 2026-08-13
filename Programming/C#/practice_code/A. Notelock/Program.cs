int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    string s = Console.ReadLine();

    int ans = 0;
    int last = -1000000000;

    for (int i = 0; i < n; i++)
    {
        if (s[i] == '1' && i - last >= k)
        {
            ans++;
        }

        if (s[i] == '1')
        {
            last = i;
        }
    }

    Console.WriteLine(ans);
}
