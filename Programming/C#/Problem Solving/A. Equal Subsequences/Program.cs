
using System.Text;

int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    for (int i = 0; i < n - k; i++)
        Console.Write(0);

    for (int i = 0; i < k; i++)
        Console.Write(1);

    Console.WriteLine();
}
