
int tc = int.Parse(Console.ReadLine());

int k;
while (tc-- > 0)
{
    k = int.Parse(Console.ReadLine());

    if (k % 3 == 1) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}
