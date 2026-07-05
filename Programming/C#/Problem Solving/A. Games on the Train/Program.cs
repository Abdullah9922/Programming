public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        while (tc-- > 0)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> list = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToList();

            int max = list.Max() + 1;
            int min = list.Min();

            Console.WriteLine(max - min);
        }
    }
}
