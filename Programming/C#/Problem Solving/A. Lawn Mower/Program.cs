public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, w;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            w = int.Parse(input[1]);

            int section = n / w;
            int removeAble = (section * (w - 1)) + (n % w);

            Console.WriteLine(removeAble);
        }
    }
}