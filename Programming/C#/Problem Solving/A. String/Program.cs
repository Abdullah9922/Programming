
int tc = int.Parse(Console.ReadLine());

while (tc-- > 0)
{
    string s = Console.ReadLine();

    Console.WriteLine(s.Count(x => x == '1'));
}