
int tc = int.Parse(Console.ReadLine());

int a, b;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);

    long start = Math.Min(a, b);
    long end = Math.Max(a, b);
    long n = end - start + 1;
    long sum = n * (a + b) / 2;

    if (sum >= Math.Min(a, b) && sum <= Math.Max(a, b)) Console.WriteLine(0);
    else if(a >= 0 && b >= 0 || a <= 0 && b <= 0)
    {
        if (a == 0 && b != 0 || a != 0 && b == 0) Console.WriteLine(Math.Max(a, b) - Math.Min(a, b) -1);
        else Console.WriteLine((Math.Max(a, b) - Math.Min(a, b)));
    }

    else
    {
        a *= -1;
        Console.WriteLine((Math.Max(a, b) - Math.Min(a, b)) - 1);
    }
}