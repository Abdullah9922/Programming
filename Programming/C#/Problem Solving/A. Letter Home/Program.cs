
int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int max = arr.Max();
    int min = arr.Min();

    int lessDis = k - min;
    int greaterDis = max - k;

    

    if(k >= max) Console.WriteLine(lessDis);

    else if(k <= min) Console.WriteLine(greaterDis);

    else if (k != max && k != min)
    {
        int ans = 0;
        ans += Math.Min(lessDis, greaterDis);
        ans += lessDis + greaterDis;

        Console.WriteLine(ans);
    }

}