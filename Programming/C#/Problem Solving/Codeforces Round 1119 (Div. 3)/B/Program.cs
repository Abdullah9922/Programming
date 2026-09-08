
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int odd = 0;
    int mod0 = 0;
    int mod2 = 0;

    foreach (int x in arr)
    {
        if (x % 2 != 0)
            odd++;
        else if (x % 4 == 0)
            mod0++;
        else
            mod2++;
    }

    Console.WriteLine(Math.Max(odd, Math.Max(mod0, mod2)));

}
