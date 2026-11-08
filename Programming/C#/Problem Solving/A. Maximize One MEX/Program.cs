
int tc = int.Parse(Console.ReadLine());

int n, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);
    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (arr.Max() == arr[n - 1]) Console.WriteLine(-1);
    else Console.WriteLine((Array.IndexOf(arr, arr.Max()) + 1) + " " + n);
}