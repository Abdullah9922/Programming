public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, h, l;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            n = int.Parse(input[0]);
            h = int.Parse(input[1]);
            l = int.Parse(input[2]);

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] <= h && arr[i + 1] <= l) sum++;
            }

            bool same = arr.All(x => x == arr[0]);

            if (same && h >= arr[0] && l >= arr[0])
            {
                if (n % 2 == 0) Console.WriteLine(n / 2);
                else Console.WriteLine(n / 2 + 1);
            }
            else Console.WriteLine(sum);


        }
    }
}