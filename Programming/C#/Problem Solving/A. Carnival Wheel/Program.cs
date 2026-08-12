public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int l, a, b;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            l = int.Parse(input[0]);
            a = int.Parse(input[1]);
            b = int.Parse(input[2]);

            int temp = 0;
            int max = 0;
            for(int i=1; i<= l; i++)
            {
                temp = (a + (i * b)) % l;
                if (temp > max) max = temp;
            }
            Console.WriteLine(max);
        }
    }
}