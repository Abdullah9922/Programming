public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        int n; 
        while (tc-- > 0)
        {
            n = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            bool same = s.All(x => x == '0');
            if (same)
            {
                Console.WriteLine(0);
            }

            else
            {
                bool newYear = s.Contains("2026");
                bool oldYear = s.Contains("2025");
                bool only5 = s.All(x => x == '5');

                if(newYear) Console.WriteLine(0);
                else if(oldYear) Console.WriteLine(1);
                else Console.WriteLine(0);

                //else if(s.Contains("202")) Console.WriteLine(1);
                //else if(s.Contains("206")) Console.WriteLine(1);
                //else if(s.Contains("226")) Console.WriteLine(1);
                //else if(s.Contains("026")) Console.WriteLine(1);

                //else if(s.Contains("20")) Console.WriteLine(2); // 2026
                //else if(s.Contains("22")) Console.WriteLine(2);
                //else if(s.Contains("26")) Console.WriteLine(2);
                //else if(s.Contains("02")) Console.WriteLine(2);
                //else if(s.Contains("06")) Console.WriteLine(2);

                //else if(only5) Console.WriteLine(4);
                //else Console.WriteLine(3);
            }
        }
    }
}