
int tc = int.Parse(Console.ReadLine());

int n, k, p;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);
    p = int.Parse(input[2]);

    if(k > 0)
    {
        if (p * n < k) Console.WriteLine(-1);
        else
        {
            if(k % p == 0) Console.WriteLine((k / p));
            else Console.WriteLine((k / p) + 1);
        }
    }

    else
    {
        k = k * (-1);
        if (p * n < k) Console.WriteLine(-1);
        else
        {
            if (k % p == 0) Console.WriteLine((k / p));
            else Console.WriteLine((k / p) + 1);
        }
    }
}