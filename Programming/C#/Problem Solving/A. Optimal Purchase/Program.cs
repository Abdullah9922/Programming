public class Solution
{
    public static void Main(string[] agrs)
    {
        int tc = int.Parse(Console.ReadLine());

        long n, a, b;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = long.Parse(input[0]);
            a = long.Parse(input[1]);
            b = long.Parse(input[2]);

            long c = n / 3;
            long d = n % 3;

            Console.WriteLine(
                Math.Min(
                    (c + 1) * b,
                    Math.Min(c * b + d * a, n * a)
                )
            );
            
        }
    }
}
