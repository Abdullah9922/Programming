public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int x, y;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            x = int.Parse(input[0]);
            y = int.Parse(input[1]);

            if (x % 2 != 0 && y % 2 != 0)
            { Console.WriteLine("NO"); }
            else
            { Console.WriteLine("YES"); }

        }
    }
}