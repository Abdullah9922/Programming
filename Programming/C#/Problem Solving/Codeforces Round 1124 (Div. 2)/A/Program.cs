int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    int temp=(n - ( k - 1));
    long amount = (long)Math.Pow(2, temp);

    Console.WriteLine(amount + (k - 1) * 2);
}