using System.Xml.Linq;

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

            int maxFreq = arr.GroupBy(x => x).Max(g => g.Count());
            int element = arr.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Key;
            int rest = arr.Count(x => x != element);


            if (n%3 == 0)
            {
                int totalHealth = arr.Sum();
                int x = (n / 3) * 2;

                if (maxFreq <= x) Console.WriteLine(totalHealth);
                else
                {
                    int y = (n / 3) - rest;
                    int validHealth = totalHealth - ((y*2) * element);

                    //Console.WriteLine("Max freq: " + maxFreq + " x: " + x + " element: " + element + " total: " + totalHealth + " valid: " + validHealth);
                    Console.WriteLine(validHealth);
                }
            }
            else if(n%3 == 2 )
            {
                int totalHealth = arr.Sum();
                int x = ((n / 3) * 2)+2;

                if (maxFreq <= x ) Console.WriteLine(totalHealth);
                else
                {
                    int y = (n / 3) - rest;
                    int validHealth = totalHealth - ((y*2) * element);
                    //Console.WriteLine("Max freq: " + maxFreq + " x: " + x + " element: " + element+ " total: "+ totalHealth + " valid: " + validHealth);
                    Console.WriteLine(validHealth);
                }
            } 
            else
            {
                int totalHealth = arr.Sum();
                int x = ((n / 3) * 2) + 1;

                if (maxFreq <= x) Console.WriteLine(totalHealth);
                else
                {
                    int y = (n / 3) - rest;
                    int validHealth = totalHealth - ((y*2) * element);
                    //Console.WriteLine("Max freq: " + maxFreq + " x: " + x + " element: " + element + " total: " + totalHealth + " valid: " + validHealth);
                    Console.WriteLine(validHealth);
                }
            }
        }
    }
}