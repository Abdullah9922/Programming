public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int max = arr.Max();
            int mex = 0;
            while (true)
            {
                bool contain = arr.Contains(mex);
                if (!contain) break;
                mex++;
                
            }
            Console.WriteLine(mex);
        }
    }
}