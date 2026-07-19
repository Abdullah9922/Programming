
public class Solution
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int k = int.Parse(Console.ReadLine());

            int[] a = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToArray();

            int maxValue = a.Max();
            int countTwo = a.Count(x => x == 2);

            if (maxValue > 2 || countTwo > 1)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}