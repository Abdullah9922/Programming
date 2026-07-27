public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        long x, y;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            x = long.Parse(input[0]);
            y = long.Parse(input[1]);

            long count = 2;
            long temp = 0;
            while (true)
            {
                temp = x * count;

                if(temp > y)
                {
                    Console.WriteLine("NO");
                    break;
                }

                if(y % temp != 0)
                {
                    Console.WriteLine("YES");
                    break;
                }
                count++;
            }
        }
    }
}
