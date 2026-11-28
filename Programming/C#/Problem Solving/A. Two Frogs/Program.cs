
int tc = int.Parse(Console.ReadLine());

int n, a, b;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    a = int.Parse(input[1]);
    b = int.Parse(input[2]);

    if (((a ^ b) & 1) != 0)
        Console.WriteLine("NO");
    else
        Console.WriteLine("YES");
}
