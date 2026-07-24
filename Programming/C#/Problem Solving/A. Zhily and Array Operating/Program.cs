public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        long n;
        while (tc-- > 0)
        {
            n = long.Parse(Console.ReadLine());

            var arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            for(long i = n-1; i > 0; i--)
            {
                if ( arr[i] + arr[i - 1] > 0)
                {

                    if(arr[i] + arr[i - 1] > arr[i - 1]) // 1 > 3
                        arr[i - 1] = arr[i] + arr[i - 1];

                    else if (arr[i-1] <= 0) 
                        arr[i - 1] = arr[i] + arr[i - 1];

                }
            }

            long count = arr.Count(s => s > 0);
            Console.WriteLine(count);
        }
    }
}
