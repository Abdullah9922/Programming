
int tc = int.Parse(Console.ReadLine());

int n, m, l, r;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    m = int.Parse(input[1]);
    l = int.Parse(input[2]);
    r = int.Parse(input[3]);

    if ((l * (-1)) >= m && l < 0) Console.WriteLine(m * (-1) + " " + 0);

    else Console.WriteLine(l + " " + (l + m));
}