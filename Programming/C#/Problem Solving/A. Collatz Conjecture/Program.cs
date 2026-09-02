using System.Numerics;

int tc = int.Parse(Console.ReadLine());

int k, x;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    k = int.Parse(input[0]);
    x = int.Parse(input[1]);

    Console.WriteLine(k << x);
}
