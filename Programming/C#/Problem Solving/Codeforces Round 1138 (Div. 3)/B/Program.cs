
int tc = int.Parse(Console.ReadLine());

int n, k, p;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);
    p = int.Parse(input[2]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Array.Sort(arr);

    int sum;
    int point = 0;
    int tempK;
    for(int i=0; i<arr.Length; )
    {
        sum = 0;
        tempK = k;
        while(tempK-->0 && i < arr.Length) sum += arr[i++];

        if (p > sum && i <= n - (n % k)  ) point += p;
        else point += sum;
    }

    Console.WriteLine(point);
}