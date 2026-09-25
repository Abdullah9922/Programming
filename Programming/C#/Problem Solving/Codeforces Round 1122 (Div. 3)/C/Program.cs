
int tc = int.Parse(Console.ReadLine());

string s;
while (tc-- > 0)
{
    s = Console.ReadLine();

    bool isSorted = s.SequenceEqual(s.OrderBy(x => x));
    if (isSorted) Console.WriteLine(0);
    else
    {
        return;
    }
}