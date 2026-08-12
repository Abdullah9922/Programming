using System.Runtime.InteropServices;

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

            int lastIndex = n - 1;
            int count = s.Count(x => x == s[lastIndex]);

            Console.WriteLine(n-count);
        }
    }
}
