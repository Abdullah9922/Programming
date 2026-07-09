using System.Runtime.InteropServices;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        while(tc --> 0)
        {
            int[] arr = Console.ReadLine()
                       .Split()
                       .Select(int.Parse)
                       .ToArray();

            int max = arr.Max();

            arr = arr.Select(i => -i).ToArray();

            int sum = arr.Sum();

            sum += max;
            sum += max;

            Console.WriteLine(sum);

        }
    }
}
