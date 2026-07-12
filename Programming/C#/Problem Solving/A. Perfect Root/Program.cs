public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while(tc--> 0)
        {
            n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
