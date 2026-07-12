using System;
using System.Linq;

public class Solution
{
    public static void Main()
    {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            int[] p = new int[n + 1];

            int[] input = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();

            for (int i = 1; i <= n; i++)
            {
                p[i] = input[i - 1];
            }

            int ind = 1;

            while (ind <= n && p[ind] == n - ind + 1)
            {
                ind++;
            }

            int id = -1;

            for (int i = ind; i <= n; i++)
            {
                if (p[i] == n - ind + 1)
                {
                    id = i;
                }
            }

            for (int i = 1; i < ind; i++)
            {
                Console.Write(p[i] + " ");
            }

            if (id != -1)
            {
                for (int i = id; i >= ind; i--)
                {
                    Console.Write(p[i] + " ");
                }

                for (int i = id + 1; i <= n; i++)
                {
                    Console.Write(p[i] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}



















/*public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            int[] arr2 = (int[])arr.Clone();
            Array.Sort(arr2);
            Array.Reverse(arr2);


            //debug code
            Console.WriteLine();
            Console.WriteLine("Arr:- ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Arr2:- ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();



            
            int indexM2 = 0, indexM = 0, max = 0, max2 = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (arr2[i] != arr[i])
                {
                    indexM2 = 0; indexM = 0; max = 0; max2 = 0;
                    indexM = Array.IndexOf(arr, arr2[i]);
                    indexM2 = Array.IndexOf(arr, arr2[i + 1]);

                    max = arr[indexM];
                    max2 = arr[indexM2];

                    arr[indexM2] = max;
                    arr[indexM] = max2;
                    
                }
                Console.WriteLine("kola- " + i);
            }

            //debug code
            Console.WriteLine($"Max index: {indexM}, Max element: {max}, Max2 index: {indexM2},  Max2 element: {max2}");

            Console.WriteLine();
            Console.WriteLine("ANS: - ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}*/
