using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);

            Console.WriteLine(x % y == 0 ? "YES" : "NO");
        }
    }
}