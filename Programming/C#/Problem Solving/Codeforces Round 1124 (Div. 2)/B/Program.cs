
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{

    public static bool Solve(int n1, int n2)
    {
        HashSet<int> seen1 = new();
        HashSet<int> seen2 = new();

        while (true)
        {
            // দুইটা same হয়ে গেলে
            if (n1 == n2)
                return true;

            // যেকোনো একটা 1 হলে
            if (n1 == 1 && n2 == 1)
                return true;

            // n1 নিজের পুরোনো value-তে ফিরে গেলে
            if (seen1.Contains(n1))
                return false;

            // n2 নিজের পুরোনো value-তে ফিরে গেলে
            if (seen2.Contains(n2))
                return false;

            seen1.Add(n1);
            seen2.Add(n2);

            // n1 এর next value
            int sum1 = 0;

            while (n1 > 0)
            {
                int digit = n1 % 10;
                sum1 += digit * digit;
                n1 /= 10;
            }

            n1 = sum1;

            // n2 এর next value
            int sum2 = 0;

            while (n2 > 0)
            {
                int digit = n2 % 10;
                sum2 += digit * digit;
                n2 /= 10;
            }

            n2 = sum2;
        }
    }


    private static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n;
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int pair = 0;
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i + 1;j < arr.Length; j++)
                {
                    if (arr[i] == arr[j]) pair++;
                    else if (arr[i] < arr[j])
                    {
                        if (Solve(arr[i], arr[j])) pair++;
                    }
                }
            }

            Console.WriteLine(pair);

        }
    }
}