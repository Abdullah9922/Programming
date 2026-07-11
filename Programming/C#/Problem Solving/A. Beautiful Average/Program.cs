public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n; 
        while(tc --> 0)
        {
            n = int.Parse((Console.ReadLine()));

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int max = arr.Max();
            int max2 = arr.OrderByDescending(x => x).Skip(1).First();

            int ans = Convert.ToInt32(Math.Ceiling((max + max2) / 2.0));
            Console.WriteLine(ans);
        }
    }
}