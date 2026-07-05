public class Solution
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(1);
                continue;
            }

            if (n == 2)
            {
                Console.WriteLine("1 2");
                continue;
            }

            List<int> ans = new List<int>();

            ans.Add(n + 2);
            ans.Add(1);
            ans.Add(2 * n - 1);

            for (int i = 2; i <= n - 2; i++)
                ans.Add(i);

            if (n >= 4)
                ans.Add(2 * n);

            Console.WriteLine(string.Join(" ", ans));
        }
    }
}