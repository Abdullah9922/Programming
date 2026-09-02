
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    var A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    var B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int ans = 1;

    for (int i = 0; i < n; i++)
    {
        if (A[i] > B[i])
        {
            ans += A[i] - B[i];
        }
    }

    Console.WriteLine(ans);
}
