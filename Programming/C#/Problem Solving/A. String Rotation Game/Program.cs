public class Solution
{
    public static void Main(String[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            int differentCharacter = s.Distinct().Count();



            if (differentCharacter == n) Console.WriteLine(n);
            else if (differentCharacter == 1) Console.WriteLine(1);
            else if (s[0] == s[n - 1] && differentCharacter != 2) Console.WriteLine(differentCharacter);
            else Console.WriteLine(differentCharacter + 1);
        }
    }
}