int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int count0 = arr.Count(x => x == 0);

    if (count0 < 2) Console.WriteLine(-1);
    else
    {
        int ans = 0;
        if (arr.First() == 1) ans++;
        if(arr.Last() == 1) ans++;

        Console.WriteLine(ans);
    }
}
