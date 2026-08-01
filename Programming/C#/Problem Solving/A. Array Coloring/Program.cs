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

            if(n == 1)
            {
                Console.WriteLine("YES");
                continue;
            }

            bool flag = true;
            bool flag2 = true;
            if (arr[0] % 2 == 0)
            {
                int i = 0;
                while (i + 1 <= arr.Length - 1)
                {
                    if (arr[i] % 2 == 0 && arr[i + 1] % 2 != 0)
                    {
                        i += 2;
                        continue;
                    }

                    else
                    {
                        flag = false;
                        flag2 = false;
                        Console.WriteLine("NO");
                        break;
                    }
                }

                if (n % 2 == 0 && flag) Console.WriteLine("YES");
                else if (arr[n - 1] % 2 == 0 && flag) Console.WriteLine("YES");
                else if(flag2) Console.WriteLine("NO");

            }

            else
            {
                int i = 0;
                while (i + 1 <= arr.Length - 1)
                {
                    if (arr[i] % 2 != 0 && arr[i + 1] % 2 == 0)
                    {
                        i += 2;
                        continue;
                    }

                    else
                    {
                        flag = false;
                        flag2 = false;
                        Console.WriteLine("NO");
                        break;
                    }
                }

                if (n % 2 == 0 && flag) Console.WriteLine("YES");
                else if (arr[n - 1] % 2 != 0 && flag) Console.WriteLine("YES");
                else if (flag2) Console.WriteLine("NO");

            }
        }
    }
}