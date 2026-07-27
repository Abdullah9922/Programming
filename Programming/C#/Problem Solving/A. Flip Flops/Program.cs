using System;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            int n = int.Parse(input[0]);
            long C = long.Parse(input[1]);
            long k = long.Parse(input[2]);

            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            Array.Sort(a);

            foreach (long x in a)
            {
                if (x > C)
                    break;

                long o = Math.Min(k, C - x);
                k -= o;
                C += x + o;
            }

            Console.WriteLine(C);
        }
    }
}