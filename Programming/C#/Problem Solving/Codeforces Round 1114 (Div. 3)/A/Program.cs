public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int a,b,c;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            a = int.Parse(input[0]);
            b = int.Parse(input[1]);
            c = int.Parse(input[2]);

            int diffAB = Math.Abs(a - b);
            int diffBC = Math.Abs(b - c);
            int diffAC = Math.Abs(a - c);

            Console.WriteLine(diffAC < diffBC 
                ? diffAB < diffAC ? diffAB : diffAC 
                : diffBC < diffAB ? diffBC : diffAB );
        }
    }
}