
int tc = int.Parse(Console.ReadLine());

string s;
while (tc-- > 0)
{
    s = Console.ReadLine();

    string temp = $"{s[0]}";
    for(int i=0; i<s.Length; i++)
    {
        if (s[i] == ' ') temp += s[i + 1];
    }

    Console.WriteLine(temp);
}