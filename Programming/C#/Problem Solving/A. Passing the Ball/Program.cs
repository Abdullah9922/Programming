public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();
            int index = s.IndexOf('L');

            Console.WriteLine(index + 1);
        }
    }
}