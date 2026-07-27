using static System.Runtime.InteropServices.JavaScript.JSType;

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

            int ans = 0;

            for (int i = 0; i < n; i++) if (a[i] > 1) ans += a[i];
            if (a[a.Length-1] == 1) ans++;

            Console.WriteLine(ans);
        }
    }
}