
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    int max = 0;
    int min = 0;

    int c = s.Count(ch => ch == '1');

    if (c <= 2)
    {
        Console.WriteLine(c - 1);
        continue;
    }

    for (int i = 0; i < n; i++)
    {
        if (s[i] == '1')
        {
            min = i + 1;
            break;
        } 
    }

    for (int i = n-1; i >= 0; i--)
    {
        if (s[i] == '1')
        {
            max = i + 1;
            break;
        }
    }

    Console.WriteLine(max - min);
}