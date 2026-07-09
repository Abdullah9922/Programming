public class Solution
{

    static bool IsSorted(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
                return false;
        }

        return true;
    }


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



            if (IsSorted(arr))
                Console.WriteLine(n);
            else
                Console.WriteLine(1);
        }
    }
}
