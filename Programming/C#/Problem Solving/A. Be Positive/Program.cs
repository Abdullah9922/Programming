
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int ans = arr.Count(c => c == 0);
    int count_1 = arr.Count(c => c == -1);

    if (count_1 % 2 == 0) Console.WriteLine(ans);
    else Console.WriteLine(ans+2);
}
