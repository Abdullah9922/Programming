public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        long r, x, d, n;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            r = long.Parse(input[0]);
            x = long.Parse(input[1]);
            d = long.Parse(input[2]);
            n = long.Parse(input[3]);

            string s = Console.ReadLine();

            long round = 0;
            bool flag = false;
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] == '2')
                {
                    if (r < x ) round++;
                }

                else
                {
                    round++;
                    if (r < x) r += d;
                    else r -= d;
                }
            }

            Console.WriteLine(round);
        }
    }
}
