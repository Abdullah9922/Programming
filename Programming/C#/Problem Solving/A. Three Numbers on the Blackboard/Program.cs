using System.ComponentModel.DataAnnotations;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int a, b, c;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            c = int.Parse(input[2]);

            int[] arr = { a, b, c };

            Array.Sort(arr);


                long x = Math.Min((long)arr[0] + arr[1], (long)arr[2]);

                Console.WriteLine(x - arr[0]);
            
        }
    }
}
