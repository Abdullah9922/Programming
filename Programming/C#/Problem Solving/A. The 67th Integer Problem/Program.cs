public class Solution
{
    public static void Main(string[] args)
    {

        int tc = int.Parse(Console.ReadLine());

        int x;
        while (tc-- > 0)
        {
            x = int.Parse(Console.ReadLine());

            if (x <= 66)
            {
                Console.WriteLine(x + 1);
            }

            else Console.WriteLine(x);
        }
    }
}
