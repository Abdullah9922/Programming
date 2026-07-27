public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, k;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            k = int.Parse(input[1]);

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int sum = arr.Sum();
            bool ans = ((n * k) % 2 == 0);

            if (sum % 2 != 0  || ans) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
