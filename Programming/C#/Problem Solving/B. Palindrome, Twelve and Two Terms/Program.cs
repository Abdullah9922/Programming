using System;
using System.IO;
using System.Text;

public class Solution
{
    static StreamReader reader;
    static StringBuilder output = new StringBuilder();

    static void Main()
    {
        reader = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(ReadToken());

        while (t-- > 0)
        {
            long n = long.Parse(ReadToken());
            Solve(n);
        }

        Console.Out.Write(output.ToString());
    }

    static void Solve(long n)
    {
        if (n == 10)
        {
            output.Append("-1\n");
        }
        else if (n % 12 == 10)
        {
            output.Append("22 ").Append(n - 22).Append('\n');
        }
        else
        {
            long a = n % 12;
            long b = n - a;
            output.Append(a).Append(' ').Append(b).Append('\n');
        }
    }

    // Reads next whitespace-separated token (handles spaces / newlines / \r safely)
    static string ReadToken()
    {
        StringBuilder sb = new StringBuilder();
        int c;

        // skip leading whitespace
        while ((c = reader.Read()) != -1 && char.IsWhiteSpace((char)c)) { }

        if (c == -1) return null;

        sb.Append((char)c);
        while ((c = reader.Peek()) != -1 && !char.IsWhiteSpace((char)c))
        {
            sb.Append((char)reader.Read());
        }

        return sb.ToString();
    }
}







/*public class Solution
{
    public static bool isPalindorme(long n)
    {
        long original = n;
        long reversed = 0;

        while (n > 0)
        {
            long digit = n % 10;
            reversed = reversed * 10 + digit;
            n /= 10;
        }

        return original == reversed;
    }

    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        long n;
        while (tc-- > 0)
        {
            n = long.Parse(Console.ReadLine());

            if(n == 1)
            {
                Console.WriteLine("1 0");
                continue;
            }

            long b = 0, a = 0, count = 1;           
            if(n >= 12)
            {
                while (true)
                {
                    b = count * 12;
                    if (b > n)
                    {
                        Console.WriteLine("-1");
                        break;
                    }

                    a = n - b;
                    if (Solution.isPalindorme(a))
                    {
                        Console.WriteLine(a + " " + b);
                        break;
                    }
                    count++;

                }
            }

            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}*/
