using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            // Step 1: Calculate original compressed length
            int blocks = 1;
            for (int i = 1; i < n; i++)
            {
                if (s[i] != s[i - 1])
                    blocks++;
            }

            int ans = blocks;

            // Step 2: Try deleting every valid character
            for (int i = 1; i < n - 1; i++)
            {
                int cur = blocks;

                if (s[i - 1] == s[i + 1] && s[i] != s[i - 1])
                {
                    cur -= 2;
                }
                else if (s[i - 1] != s[i] &&
                         s[i + 1] != s[i] &&
                         s[i - 1] != s[i + 1])
                {
                    cur -= 1;
                }

                ans = Math.Min(ans, cur);
            }

            Console.WriteLine(ans);
        }
    }
}