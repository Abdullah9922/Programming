public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        string s;
        while (tc-- > 0)
        {
            s = Console.ReadLine();
            char[] arr = s.ToCharArray();

            bool allN = arr.All( x => x == 'N' );
            int countY = arr.Count(x => x == 'Y');

            if (allN) Console.WriteLine("YES");
            else if (countY <= 1) Console.WriteLine("YES");
            else Console.WriteLine("NO");


        }
    }
}
