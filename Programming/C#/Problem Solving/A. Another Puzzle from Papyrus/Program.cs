public class Solution
{
    public static void Main(string[] agrs)
    {
        int tc = int.Parse(Console.ReadLine());

        int n, c;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            c = int.Parse(input[1]);

            var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            var b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] x = new int[n];
            Array.Copy(a, x, n);

            long costWithOutSort = 0;
            int temp = 0;
            for (int i=0; i<n; i++)
            {
                if (b[i] < x[i])
                {
                    temp = x[i] - b[i];
                    costWithOutSort += temp;
                    x[i] = x[i] - temp;
                }
            }

            bool isEqual = x.SequenceEqual(b);
            if (!isEqual)
            {
                costWithOutSort = 999999999999;
            }

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("---->  " + x[i]);
            //}


            Array.Sort(a);
            Array.Sort(b);

            var flag = true;
            for(int i=0; i<n; i++)
            {
                if (b[i] > a[i])
                {
                    Console.WriteLine(-1);
                    flag = false;
                    break;
                }

                else if (b[i] == a[i])
                {
                    continue;
                }
                else
                {
                    c += a[i] - b[i];
                }
            }

            if (flag) Console.WriteLine( c < costWithOutSort ? c : costWithOutSort);
















            //int sum_a = a.Sum();
            //int sum_b = b.Sum();

            //if(sum_b > sum_a)  Console.WriteLine("---->  "+ -1);

            //else if( sum_a == sum_b ) Console.WriteLine("---->  " + c);

            //else
            //{
            //    Console.WriteLine("---->  " + (sum_a - sum_b) + c);
            //}

        }
    }
}
