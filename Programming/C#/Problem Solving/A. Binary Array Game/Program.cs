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

            if (arr[0] + arr[n-1] != 0) Console.WriteLine("Alice");
            else Console.WriteLine("Bob");
        }
    }
}