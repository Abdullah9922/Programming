
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int min = Math.Min(arr[0],Math.Min(arr[1],arr[2]));
    Console.WriteLine(n - min);
}