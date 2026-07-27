public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, k;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            k = int.Parse(input[1]);

            if (n == 3 && k == 2)
            {
                Console.WriteLine(-1);
                continue;
            }

            char[] arr = new char[n];
            Array.Fill(arr, '0');

            int index = 0;
            if (n % 2 ==0)
            {
                if (k > n / 2)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                else
                {
                    n /= 2;
                    while (n-- > 0)
                    {
                        arr[index++] = '1';
                    }
                }

            }

            else
            {
                if (k > (n / 2) + 1)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                else
                {
                    n /= 2;
                    n += 1;
                    while (n-- > 0)
                    {
                        arr[index++] = '1';
                    }
                }
            }

            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }
    }
}
