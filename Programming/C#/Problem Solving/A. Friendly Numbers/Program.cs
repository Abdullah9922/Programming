using System;

class Program
{
    static int DigSum(int n)
    {
        int sum = 0;

        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int ans = 0;

            for (int i = n; i < n + 200; i++)
            {
                if (i - DigSum(i) == n)
                {
                    ans++;
                }
            }

            Console.WriteLine(ans);
        }
    }
}