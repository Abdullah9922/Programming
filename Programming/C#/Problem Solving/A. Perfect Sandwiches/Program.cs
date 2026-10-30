
int tc = int.Parse(Console.ReadLine());

int a, b;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = int.Parse(input[0]);
    b = int.Parse(input[1]);

    if (b >= a) Console.WriteLine(-1);
    else
    {
        Console.WriteLine(Math.Min(b, a - b));
    }
}