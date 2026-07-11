public class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        bool ans1 = s.Contains("1111111");
        bool ans0 = s.Contains("0000000");

        if (ans1 || ans0)
        {
            Console.WriteLine("YES");
        }

        else Console.WriteLine("NO");
    }
}