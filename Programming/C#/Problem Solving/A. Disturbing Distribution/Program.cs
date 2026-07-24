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

            bool flag = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 1 && flag)
                {
                    flag = false;
                    continue;
                }

                if(arr[i] == 1 && flag == false)
                {
                    arr[i] = 0;
                }
            }

            Console.WriteLine(arr.Sum());
        }
    }
}