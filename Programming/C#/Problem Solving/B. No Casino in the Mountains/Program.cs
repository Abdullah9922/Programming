
int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int hike = 0;
    int tempK = k;
    bool flag = true;
    for(int i=0; i<=n-k; i++)
    {
        if (arr[i] == 0)
        {
            tempK = k;
            while (tempK-- > 0)
            {
                if (arr[i++] != 0) flag = false;
            }
            if (flag)
            {
                hike++;
                flag = true;
            }
        }
    }

    Console.WriteLine(hike);
}
