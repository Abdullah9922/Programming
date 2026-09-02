int tc = int.Parse(Console.ReadLine());

int a, b;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    a = int.Parse(input[0]);
    b = int.Parse(input[1]);

    if (a == b) Console.WriteLine(0);
    else if (a % b == 0 || b % a == 0) Console.WriteLine(1);
    else Console.WriteLine(2);
}
