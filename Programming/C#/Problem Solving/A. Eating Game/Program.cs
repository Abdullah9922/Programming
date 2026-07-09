public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while(tc-->0)
        {
            n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();

            int count = arr.Count( x => x == arr.Max());

            Console.WriteLine(count);
        }
    }
}
