using System;
using System.Linq;
public class Solution
{

    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            int maxDiffIndex = 0;
            int maxDiff = 0;
            int temp = 0;
            int sum = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                temp = Math.Abs(arr[i] - arr[i + 1]);
                if (temp > maxDiff)
                {
                    if (i == 0) maxDiffIndex = 0;
                    else if (i + 2 < n && (arr[i + 1] - arr[i + 2] == 0)) maxDiffIndex = i;
                    else if (arr[i] > arr[i + 1]) maxDiffIndex = i;
                    else maxDiffIndex = i + 1;
                    maxDiff = temp;
                }
            }

            int[] arrNew = arr.Where((value, index) => index != maxDiffIndex).ToArray();

            for (int i = 0; i < arrNew.Length - 1; i++)
            {
                sum += Math.Abs(arrNew[i] - arrNew[i + 1]);
            }
            Console.WriteLine(sum);
        }
    }
}