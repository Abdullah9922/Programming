public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            arr = arr.OrderBy(x => x).ToArray();

            int best = 0;

            foreach (int x in arr)
            {
                int next = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] - x == next)
                    {
                        next++;
                    }
                }

                best = Math.Max(best, next);
            }

            Console.WriteLine(best);











            /*bool contain = arr.Contains(0);

            int mex = 0;
            if (contain)
            {
                int smallest = arr.Min();
                arr = arr.Select(x => x - smallest).ToArray();
                mex = Enumerable.Range(0, arr.Length + 1)
                    .First(x => !arr.Contains(x));
            }
            else
            {
                int minPositive = arr.Any(x => x > 0)? arr.Where(x => x > 0).Min(): arr.Min();
                arr = arr.Select(x => x - minPositive).ToArray();
                mex = Enumerable.Range(0, arr.Length + 1)
                    .First(x => !arr.Contains(x));
            }

            Console.WriteLine(mex);*/
        }
    }
}
