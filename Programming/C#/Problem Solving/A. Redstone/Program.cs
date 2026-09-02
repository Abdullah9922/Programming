
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (arr.Length != arr.Distinct().Count()) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}
