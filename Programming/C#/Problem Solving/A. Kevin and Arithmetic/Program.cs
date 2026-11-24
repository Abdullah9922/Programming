
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int countOdd = arr.Count(x => x % 2 != 0);
    int countEven1 = arr.Count(y => y % 2 == 0 && (y/2) % 2 != 0);
    int countEven2 = arr.Count(y => y % 2 == 0 && (y/2) % 2 == 0);



    if (countEven1 > 0 && countOdd >= countEven2) Console.WriteLine(countOdd + 1);
    else
    {
        if (countEven2 == 0 && countEven1 > 0) Console.WriteLine(1);
        else Console.WriteLine(countEven2);
    }
}