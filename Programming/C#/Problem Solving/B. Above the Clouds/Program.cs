
int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    bool ans = false;
    for(int i=s.Length-2; i>0; i--)
    {
        for(int j=0; j < i; j++)
        {
            if (s[i] == s[j]) ans = true;
        }
    }

    for (int i = 1; i <= s.Length - 2; i++)
    {
        for (int j = i+1; j <= s.Length-1; j++)
        {
            if (s[i] == s[j]) ans = true;
        }
    }

    if (ans) Console.WriteLine("YES");
    else Console.WriteLine("NO");
}