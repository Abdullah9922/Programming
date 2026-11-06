
int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (n / k == 1)
    {
        Console.WriteLine(arr.Min()+1);
        continue;
    }

    int ans = 0;
    while (true)
    {
        if (!arr.Contains(ans))
        {
            Console.WriteLine(ans); break;
        }
        ans++;
    }
}