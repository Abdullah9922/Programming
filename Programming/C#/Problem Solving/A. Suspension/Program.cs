public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while(tc--> 0)
        {
            n = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();
            int y = int.Parse(input[0]);
            int r = int.Parse(input[1]);

            int suspended = 0;
            suspended += r;
            suspended += y / 2;

            if (suspended <= n) Console.WriteLine(suspended);
            else Console.WriteLine(n);

        }
    }
}
