
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    if (n % 4 == 0) Console.WriteLine("Bob");
    else Console.WriteLine("Alice");
}