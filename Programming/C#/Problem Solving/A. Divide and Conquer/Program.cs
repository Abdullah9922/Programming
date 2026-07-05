using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            bool ok = true;

            if(y > x)
            {
                Console.WriteLine("NO");
                continue;
            }

            for (int i = 2; i <= x ; i++)
            {
                if(x % i == 0)
                {
                    x /= i;
                    i = 1;
                }

                if (y == x)
                {
                    Console.WriteLine("YES");
                    ok = false;
                    break;
                }
            }

            if (ok)
                Console.WriteLine("NO");
        }
    }
}