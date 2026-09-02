
int tc = int.Parse(Console.ReadLine());

string s;
while (tc-- > 0)
{
    s = Console.ReadLine();

    char[] arr = s.ToCharArray();
    Array.Sort(arr);
    Array.Reverse(arr);

    s = new string(arr);

    Console.WriteLine(s);
}