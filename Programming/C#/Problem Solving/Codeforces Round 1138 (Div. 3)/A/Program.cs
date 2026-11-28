
int tc = int.Parse(Console.ReadLine());

int l,a,b;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    l = int.Parse(input[0]);
    a = int.Parse(input[1]);
    b = int.Parse(input[2]);

    int[] arr = new int[l];
    int[] arr2 = new int[l];
    
    int ans = 0;
    int count = 0;
    int index = 0;

    while (true)
    {
        index = (a * count++) % l;
        if (arr[index] == 1) break;
        else arr[index]++;
    }

    index = 0;
    count = 0;
    while (true)
    {
        index = (b * count++) % l;
        if (arr2[index] == 1) break;
        else arr2[index]++;
    }

    for (int i = 0; i < l; i++)
    {
        if (arr[i] == 1 && arr2[i] == 1) ans++;
    }

    Console.WriteLine(ans);
}