public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());
            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Array.Sort(a);

            bool flag = true;
            for (int i = 1; i <= n - 2; i += 2)
            {
                if (a[i] != a[i + 1])
                {
                    Console.WriteLine("NO");
                    flag = false;
                    break;
                }
            }

            if(flag) Console.WriteLine("YES");
        }
    }
}