int tc = int.Parse(Console.ReadLine());

while (tc-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    var arr = Array.ConvertAll(
        Console.ReadLine().Split(),
        int.Parse
    ).ToList();

    bool flag = true;

    while (arr.Count > 3)
    {
        int max = arr.Max();
        int index = arr.IndexOf(max);

        bool canRemove = false;

        if (index + 1 < arr.Count &&
            arr[index + 1] == max - 1)
        {
            canRemove = true;
        }

        if (index - 1 >= 0 &&
            arr[index - 1] == max - 1)
        {
            canRemove = true;
        }

        if (canRemove)
        {
            arr.RemoveAt(index);
        }
        else
        {
            Console.WriteLine("NO");
            flag = false;
            break;
        }
    }

    if (flag && arr[1] != 1)
        Console.WriteLine("YES");
    else if (flag)
        Console.WriteLine("NO");
}