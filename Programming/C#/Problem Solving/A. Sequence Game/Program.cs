public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n,x;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            x = int.Parse(Console.ReadLine());

            int max = arr.Max();
            int min = arr.Min();

            if (x >= min && x <= max) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}