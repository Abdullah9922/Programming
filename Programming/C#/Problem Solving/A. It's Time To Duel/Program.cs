
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    bool flag = true;

    if (arr.Sum() == n)
    {
        Console.WriteLine("YES");
        continue;
    }

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == 0 && arr[i + 1] == 0)
        {
            Console.WriteLine("YES");
            flag = false;
            break;
        }
    }

    if( flag )  Console.WriteLine("NO");
}