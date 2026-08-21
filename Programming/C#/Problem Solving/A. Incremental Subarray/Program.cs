using System.Text;

int tc = int.Parse(Console.ReadLine());

int n, m;
StringBuilder s = new StringBuilder();
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    m = int.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    bool isSorted = arr.SequenceEqual(arr.OrderBy(x => x));
    int count = arr.Distinct().Count();

    if (isSorted && count == m)
    {
        int max = arr.Max();
        int ans = n - (max - 1);
        Console.WriteLine(ans);
    }

    else Console.WriteLine(1);
}
