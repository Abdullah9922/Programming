public class Solution
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

            Array.Sort(arr);

            int cnt = 0;
            for (int i = 0; i < n; i++)
            { 
                if (arr[i] != arr[n - 1 - i])
                    cnt++; 
            }

            Console.WriteLine(cnt/2);
        }
    }
}
