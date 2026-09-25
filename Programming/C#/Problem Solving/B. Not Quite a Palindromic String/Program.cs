
int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    string s = Console.ReadLine();

    char[] arr = s.ToCharArray();

    //int count1 = arr.Count( x => x == 1);
    //int count0 = arr.Count( x => x == 0);

    //if(count1 / 2 >= k)
    //{
    //    int restPair = (count1 / 2) - k;

    //}

    //else if(count0 / 2 >= k)
    //{
    //    int restPair = (count1 / 2) - k;
    //}

    Array.Sort(arr);
    bool flag = true;
    int firstIndex = 0;
    int lastIndex = arr.Length - 1;
    k = (n - k);

    while (k-- > 0)
    {
        if (arr[firstIndex] == arr[lastIndex])
        {
            Console.WriteLine("NO");
            flag = false;
            break;
        }
        firstIndex++;
        firstIndex--;
    }

    int count0 = 0;
    int count1 = 0;

    for (int i = firstIndex; i <= firstIndex; i++)
    {
        if (s[i] == '0')
            count0++;
        else if (s[i] == '1')
            count1++;
    }

    if (flag && count0 % 2 == 0 && count1 % 2 == 0) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}
