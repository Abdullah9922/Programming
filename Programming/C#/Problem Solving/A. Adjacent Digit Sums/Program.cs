
int tc = int.Parse(Console.ReadLine());

int x, y;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    x = int.Parse(input[0]);
    y = int.Parse(input[1]);

    if (x + 1 >= y && (x + 1 - y) % 9 == 0) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}