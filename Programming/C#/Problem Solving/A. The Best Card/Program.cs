public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            bool flag = true;
            for(int i=2; i<= n; i++)
            {
                if ((n + 1) % i == 0)
                {
                    Console.WriteLine("NO");
                    flag = false;
                    break;
                }
            }

            if (flag) Console.WriteLine("YES");
        }
    }
}