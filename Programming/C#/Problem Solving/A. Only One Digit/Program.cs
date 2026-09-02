int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    int temp, min=int.MaxValue;
    while(n > 0)
    {
        temp = n % 10;
        n /= 10;

        if (temp < min) min = temp;
    }
    Console.WriteLine(min);
}
