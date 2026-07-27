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

            if (n == 1) Console.WriteLine(1);

            else
            {
                n -= 1;
                while (n-- > 0)
                {
                    Console.Write("2 ");
                }
                Console.WriteLine("2");
            }
        }
    }
}