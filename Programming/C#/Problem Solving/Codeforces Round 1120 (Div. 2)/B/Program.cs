int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    if (k == 0) Console.WriteLine(-1);
    else
    {
        if (n % 2 == 0) Console.WriteLine(-1);
        else
        {
            int count = 1;
            for(int i=1;  i<=n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(count++ + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
