public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int x, y;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            x = int.Parse(input[0]);
            y = int.Parse(input[1]);

            if (y < 0)
            {
                if (x % 4 == 0 && -y * 4 == x) Console.WriteLine("YES");

                else if (x % 4 == 0 && y != 0)
                {
                    y *= -1;
                    if ((y + 2) * 4 == x) Console.WriteLine("YES");
                    else if(((y + 1) * 4) + 2 == x) Console.WriteLine("YES");
                }

                else if(x == 6 && y == 0) Console.WriteLine("YES");

                else Console.WriteLine("NO");
            }

            else
            {
                if (y * 2 == x) Console.WriteLine("YES");
                else if (y == 0 && x % 3 == 0) Console.WriteLine("YES");
                else
                {
                    Console.WriteLine("NO");
                }

            }
        }
    }
}