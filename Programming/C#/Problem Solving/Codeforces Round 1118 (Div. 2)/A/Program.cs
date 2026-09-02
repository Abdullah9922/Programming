
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int a = arr[0];
    int index = arr.Length;
    int b = arr[index-1];
    while (b != 0)
    {
        int temp = a % b;
        a = b;
        b = temp;
    }

    Console.WriteLine(a);
}
