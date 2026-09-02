
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int ans = 0;
    for (int i = 0; i < n; i++)
    {
        ans += arr[i] + (arr[i] == 0 ? 1 : 0);
    }

    Console.WriteLine(ans);
}
