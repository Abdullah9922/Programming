int tc = int.Parse(Console.ReadLine());

int n, a, b;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    n = int.Parse(input[0]);
    a = int.Parse(input[1]);
    b = int.Parse(input[2]);

    if (a <= b) Console.WriteLine((n % 2) == (b % 2) ? "YES" : "NO");
    else Console.WriteLine((n % 2) == (b % 2) && (n % 2) == (a % 2) ? "YES" : "NO");

}