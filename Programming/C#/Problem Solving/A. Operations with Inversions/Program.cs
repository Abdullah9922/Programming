public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while(tc --> 0)
        {
            n = int.Parse(Console.ReadLine());

            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int count = 0;
            for(int i=0; i<arr.Length-1; i++)
            {
                if (arr[i] == -1) continue;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == -1) continue;

                    if (arr[i] > arr[j])
                    {
                        count++;
                        arr[j] = -1;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}