
int tc = int.Parse(Console.ReadLine());

int n, x;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    x = int.Parse(input[1]);

    var arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if ( arr.Sum()  == (n*x)) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}