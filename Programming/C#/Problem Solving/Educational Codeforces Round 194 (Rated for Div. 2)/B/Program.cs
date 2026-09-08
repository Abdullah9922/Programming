using System;
using System.Numerics;

int tc = int.Parse(Console.ReadLine());

while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    long x = long.Parse(input[0]);
    long y = long.Parse(input[1]);
    long k = long.Parse(input[2]);

    long d = y - x;
    long ans = 0;

    while (k > 0 && x <= d)
    {
        ans += d % x;
        x++;
        k--;
    }

    ans += k * d;

    Console.WriteLine(ans);
}