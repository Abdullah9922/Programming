
int tc = int.Parse(Console.ReadLine());

long n, c;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = long.Parse(input[0]);
    c = long.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

    Array.Sort(arr);
    //Array.Reverse(arr);

    int coin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > c)
        {
            coin++;
        }
        arr = arr.Select(x => x * 2).ToArray();
    }

    Console.WriteLine(coin);
}
