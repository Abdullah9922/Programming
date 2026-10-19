
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int ans = arr.Sum();
    ans -= (n - 1);

    Console.WriteLine(ans);
}