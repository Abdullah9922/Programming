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

            Array.Sort(arr);
            int deletion = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i+=count )
            {
                count = arr.Count(x => x == arr[i]);

                if (count > arr[i]) deletion += count - arr[i];
                else if (count < arr[i]) deletion += count;
            }

            Console.WriteLine( deletion);
        }
    }
}
