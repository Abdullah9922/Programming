public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, s, x;
        while(tc --> 0)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            s = int.Parse(input[1]);
            x = int.Parse(input[2]);


            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int sum = arr.Sum();
            int sub = s - sum;

            if (sum > s)
            {
                Console.WriteLine("NO");
                continue;
            }

            if(sub == 0 || sub % x == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
