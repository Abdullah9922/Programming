using System;
using System.Linq;

public class Cp
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        for (int i = 0; i < tc; i++)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            for (int j = 0; j < n - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    arr[j + 1] = arr[j];
                }
            }

            int sum = 0;
            for (int j = 0; j < n; j++)
            {
                sum += arr[j];
            }

            Console.WriteLine(sum);
        }
    }
}