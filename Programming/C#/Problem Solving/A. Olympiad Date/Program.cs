int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int count0 = 0;
    int count1 = 0;
    int count2 = 0;
    int count3 = 0;
    int count5 = 0;

    bool flag = true;
    for(int i=0; i<arr.Length; i++)
    {
        if (arr[i] == 0) count0++;
        else if (arr[i] == 1) count1++;
        else if (arr[i] == 2) count2++;
        else if (arr[i] == 3) count3++;
        else if (arr[i] == 5) count5++;

        if(count0 >= 3 && count1 >= 1 && count2 >= 2 && count3 >= 1 && count5 >= 1)
        {
            Console.WriteLine(i + 1);
            flag = false;
            break;
        }
    }

    if (flag) Console.WriteLine(0);
}