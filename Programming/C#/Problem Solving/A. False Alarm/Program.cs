
int tc = int.Parse(Console.ReadLine());

int n, x;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    x = int.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int index = Array.IndexOf(arr, 1);

    bool flag = true;
    if (index + x >= arr.Length)
    {
        flag = false;
        Console.WriteLine("YES");
    }
    else
    {
        for(int i=index+x; i < arr.Length; i++)
        {
            if (arr[i] == 1)
            {
                Console.WriteLine("NO");
                flag = false;
                break;
            }
        }
    }

    if (flag) Console.WriteLine("YES");
}
