
int tc = int.Parse(Console.ReadLine());

long a, b, c;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    a = long.Parse(input[0]);
    b = long.Parse(input[1]);
    c = long.Parse(input[2]);

    long preDiff = Math.Abs(a - b);
    a += c;
    long postDiff = Math.Abs(a - b);

    Console.WriteLine(preDiff >  postDiff ? preDiff : postDiff);
}
