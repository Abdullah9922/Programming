
int tc = int.Parse(Console.ReadLine());

int s;
while (tc-- > 0)
{
    s = int.Parse( Console.ReadLine());

    double root = Math.Sqrt(s);

    if (root == (int)root)
    {
        Console.WriteLine(0 + " " + root);
    }
    else Console.WriteLine(-1);
}
