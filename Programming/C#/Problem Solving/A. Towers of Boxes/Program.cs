public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, m, d;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            m = int.Parse(input[1]);
            d = int.Parse(input[2]);

            int temp = (d / m)+1;

            if (n % temp == 0) Console.WriteLine(n / temp);
            else Console.WriteLine((n / temp) + 1);
        }
    }
}
