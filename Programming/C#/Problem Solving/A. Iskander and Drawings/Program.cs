using System.ComponentModel.DataAnnotations;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            int count = 0, ans = 0;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '*')
                {
                    count = 0;
                }
                else count++;

                ans = Math.Max(ans, (count + 1) / 2);
            }

            Console.WriteLine(ans);
        }
    }
}
