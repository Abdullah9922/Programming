
int tc = int.Parse(Console.ReadLine());

int l, r;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    l = int.Parse(input[0]);
    r = int.Parse(input[1]);

    if (l != r) Console.WriteLine(r - l);
    else if (r == l && r != 1) Console.WriteLine(0);
    else Console.WriteLine(1);
}