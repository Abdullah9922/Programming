
int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int[] input = Console.ReadLine()!
        .Split()
        .Select(int.Parse)
        .ToArray();

    int n = input[0];
    int k = input[1];

    int ans = 0;

    if (n % 2 == 1)
    {
        n -= k;
        ans = 1;
    }

    k -= 1;

    ans += (n + k - 1) / k;

    Console.WriteLine(ans);
}