
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


    if (arr.Distinct().Count() == 1)
    {
        Console.WriteLine(arr.Length);
        continue;
    }


    List<int> freq = new List<int>();

    int count = 1;

    for (int i = 1; i < n; i++)
    {
        if (arr[i] == arr[i - 1])
            count++;
        else
        {
            freq.Add(count);
            count = 1;
        }
    }

    freq.Add(count);
    int ans = 0;

    foreach (int x in freq)
    {
        int cnt = 0;

        foreach (int f in freq)
        {
            if (f >= x)
                cnt++;
        }

        ans = Math.Max(ans, x * cnt);
    }

    Console.WriteLine(ans);
}
