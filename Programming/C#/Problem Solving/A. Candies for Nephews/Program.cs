int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    if (n % 3 == 0) Console.WriteLine(0);
    else
    {
        int temp = n / 3;
        temp += 1;
        Console.WriteLine((temp*3)-n);
    }
}
