
int tc = int.Parse(Console.ReadLine());
int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    bool flag = true;
    for (int i = 1; i < n - 2; i++)
    {
        if (arr[i] == 1 && arr[i + 1] == 1)
        {
            Console.WriteLine("NO");
            flag = false;
            break;
        }
    }

    if (flag) Console.WriteLine("YES");
}
