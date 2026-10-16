
int tc = int.Parse(Console.ReadLine());

int x, y, a;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    x = int.Parse(input[0]);
    y = int.Parse(input[1]);
    a = int.Parse(input[2]);

    if (a % (x + y) < x)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}