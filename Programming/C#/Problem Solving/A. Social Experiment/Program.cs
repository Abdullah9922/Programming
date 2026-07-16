public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while(tc-->0)
        {
            n = int.Parse(Console.ReadLine());

            if (n == 2) Console.WriteLine(2);
            else if (n == 3) Console.WriteLine(3);
            else if(n >= 4)
            {
                Console.WriteLine(n % 2);
            }
        }
    }
}
