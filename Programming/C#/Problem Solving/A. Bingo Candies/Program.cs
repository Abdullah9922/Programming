public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n; 
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n,n];

            for(int i=0; i<n; i++)
            {
                var temp = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = temp[j];
                }
            }

            if (n == 1)
            {
                Console.WriteLine("NO");
                continue;
            }

            int maxFreq = arr.Cast<int>()
                 .GroupBy(x => x)
                 .Max(g => g.Count());
            //Console.WriteLine("=============> " + maxFreq);

            if ( n == 2)
            {
                if(maxFreq >= 3) Console.WriteLine("NO");
                else Console.WriteLine("YES");
                continue;
            }

            if (maxFreq >= (n * 2)) Console.WriteLine("NO");
            else Console.WriteLine("YES");
        }
    }
}