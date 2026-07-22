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

            int largest = arr.Max();
            int smallest = arr.Min();

            int diff = largest - smallest;

            if(diff % 2 == 0)
            {
                Console.WriteLine(diff / 2);
            }
            else Console.WriteLine(diff / 2 + 1);
        }
    }
}
