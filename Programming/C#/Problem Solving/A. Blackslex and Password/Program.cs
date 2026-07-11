public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int k, x;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            k = int.Parse(input[0]);
            x = int.Parse(input[1]);

            int mul = k * x;
            mul += 1;

            Console.WriteLine(mul);

        }
    }
}
