public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            if (n > 4)
            {
                if (n % 4 == 0) Console.WriteLine((n / 4) + 1);
                else
                {
                    int x = n / 4;
                    if ((x*4) + 2 == n) Console.WriteLine(x + 1);
                    else Console.WriteLine(0);
                }
            }
            else if (n == 2 ) Console.WriteLine(1);
            else if ( n == 4) Console.WriteLine(2);
            else Console.WriteLine(0);
        }
    }
}