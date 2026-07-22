public class Solutin
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count0 = arr.Count(c => c == 0);
            int count1 = arr.Count(c => c == 1);
            int count2 = arr.Count(c => c == 2);

            if (count1 == count2)
            {
                Console.WriteLine(count1 + count0);
            }
            else if (count1 > count2)
            {
                Console.WriteLine(count2 + ((count1-count2) / 3) + count0);
            }
            else
            {
                Console.WriteLine(count1 + ((count2-count1) / 3) + count0);
            }
        }
    }
}