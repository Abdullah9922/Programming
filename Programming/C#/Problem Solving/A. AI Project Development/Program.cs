public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n,x,y,z;
        while (tc-- > 0)
        {
            string[] input = Console.ReadLine().Split();

            n = int.Parse(input[0]);
            x = int.Parse(input[1]);
            y = int.Parse(input[2]);
            z = int.Parse(input[3]);

            //Console.WriteLine("TEST CASE: " + ++tc);
            //tc--;
            // without AI 
            int hour = 0;
            if(x + y >= n)
            {
                hour = 1;
            }

            //else if(x + y == n)
            //{
            //    hour = 
            //    //hour = x < y ? x : y;
            //    //Console.WriteLine(x);
            //    //continue;
            //}

            else
            {
                int temp = (int)Math.Ceiling((double)n / (x + y));
                hour = temp;
                //Console.WriteLine(temp);
            }


            //with AI
            int temp2 = 0;
            int extra = x * z;
            y *= 10;
            int hourAI = 0;
            do
            {
                hourAI++;
                temp2 = ((x + y) * hourAI);

            }
            while (n > (temp2 + extra));

            hourAI += z;
            int ans = Math.Min(hour, hourAI);
            //Console.WriteLine("------Hour------> " + hour);
            //Console.WriteLine("-----HourAI-------> " + hourAI);
            Console.WriteLine( ans);
            //Console.WriteLine();
            //Console.WriteLine();
        }
    }
}