using System;

public class Solution
{
    public static void Main()
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int x = 0;
            for (int i = 0; i < n; i++)
            {
                if (int.Parse(input[i]) == -1)
                    x++;
            }

            if (n % 2 != 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine((x % 2 == (n / 2) % 2) ? "YES" : "NO");
            }
        }
    }
}