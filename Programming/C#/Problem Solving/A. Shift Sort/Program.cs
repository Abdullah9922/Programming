int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());

    string s = Console.ReadLine();

    int count1 = s.Count(s => s == '1');
    int ans = 0;

    int index = s.Length;
    while(count1-->0)
    {
        index--;
        if (s[index] == '0') ans++;
    }

    Console.WriteLine(ans);
}
