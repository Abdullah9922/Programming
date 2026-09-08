public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            int ans = 0;

            while (n > 2)
            {
                ans += n / 3;
                n = n / 3 + (n % 3);
            }

            Console.WriteLine(ans);
        }
    }
}
