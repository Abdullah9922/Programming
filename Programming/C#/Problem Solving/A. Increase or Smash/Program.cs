using System;
using System.Linq;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            var arr = Array.ConvertAll(
                Console.ReadLine().Split(),
                int.Parse
            );

            int x = arr.Distinct().Count();

            Console.WriteLine((x * 2) - 1);
        }
    }
}