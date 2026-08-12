public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, a;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            a = int.Parse(input[1]);

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int l = 0, r = 0;

            for (int i = 0; i < n; i++)
            {
                if (a > arr[i]) l++;
                if (a < arr[i]) r++;
            }

            Console.WriteLine(l > r ? a - 1 : a + 1);
        }
    }
}