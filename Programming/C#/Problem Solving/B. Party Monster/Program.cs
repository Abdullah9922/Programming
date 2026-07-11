using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == '(')
                    cnt++;
            }

            Console.WriteLine(2 * cnt == n ? "YES" : "NO");
        }
    }
}