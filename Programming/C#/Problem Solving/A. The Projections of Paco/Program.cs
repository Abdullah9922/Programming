
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (n == 1) Console.WriteLine(arr[0]);
    else
    {
        int sum = arr.Sum();
        if (sum < 0) Console.WriteLine(sum);
        else Console.WriteLine((sum- arr.Max() ) -arr.Max());
    }
}