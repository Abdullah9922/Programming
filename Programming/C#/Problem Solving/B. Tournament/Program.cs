
int tc = int.Parse(Console.ReadLine());

int n, j, k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    j = int.Parse(input[1]);
    k = int.Parse(input[2]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int mx = arr.Max();
    if (k > 1 || arr[j-1] == mx)
        Console.WriteLine("YES");
    else
        Console.WriteLine("NO");


}