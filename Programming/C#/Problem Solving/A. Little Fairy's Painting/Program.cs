public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            List<int> list = Array.ConvertAll(Console.ReadLine().Split(), int.Parse).ToList();

            int count = 0;
            bool contain;
            while (true)
            {
                count = list.Distinct().Count();
                contain = list.Contains(count);

                if( contain )
                {
                    Console.WriteLine(count);
                    break;
                }

                list.Add(count);
            }
            
        }
    }
}