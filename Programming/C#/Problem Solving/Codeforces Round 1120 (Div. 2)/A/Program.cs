
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int count0 = arr.Count(x => x == 0);
    int count1 = arr.Count(x => x == 1);

    if (count0 > count1) Console.WriteLine("Elsie");
    else Console.WriteLine("Bessie");
}
