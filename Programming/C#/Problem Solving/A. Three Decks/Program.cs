
int tc = int.Parse(Console.ReadLine());

int a, b, c;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);
    c = int.Parse(input[2]);

    if ((a + b + c) % 3 != 0) Console.WriteLine("NO");
    else
    {
        if (b - a <= c - b) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}
