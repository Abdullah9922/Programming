using System;
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

            string s = Console.ReadLine();

            int sleep = 0;
            int i = 0;
            while (i<n)
            {
                if (s[i] == '0')
                {
                    sleep++;
                    i++;
                }
                else
                {
                    //i += k;

                    //if (s[i] == '0')
                    //{
                    //    i++;
                    //    continue;
                    //}
                    //else i += k;




                    while (true)
                    {
                        if (s[i] == '0')
                        {
                            i += k;
                            break;
                        }
                        i++;
                        if (i >= n) break;
                    }
                }
            }
            Console.WriteLine(  sleep);
        }
    }
}