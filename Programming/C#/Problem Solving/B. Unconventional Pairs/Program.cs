
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
            int max = 0, temp = 0;
            for (int i = 0; i < arr.Length; i += 2)
            {
                temp = arr[i + 1] - arr[i];
                if (temp > max) max = temp;
            }
            Console.WriteLine(max);
        }
    }
}


