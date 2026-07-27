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

            if (n % 2 == 0)
            {
                int minOdd = int.MaxValue;
                int maxEven = int.MinValue;

                for(int i=0; i<n; i++)
                {
                    if(i % 2 == 0) minOdd = Math.Min(minOdd, arr[i]);
                    else maxEven = Math.Max(maxEven, arr[i]);
                }

                Console.WriteLine((minOdd - maxEven) >= 2 ? "YES" : "NO");
            }

            else   Console.WriteLine("NO");

        }
    }
}
