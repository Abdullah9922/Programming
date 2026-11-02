int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    int[] arr = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

    int x0 = arr[0];
    int y0 = arr[1];
    int r = arr[2];

    Console.WriteLine($"{x0} {y0 + r}");
}