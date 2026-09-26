int tc = int.Parse(Console.ReadLine());

int n;
char c;

while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();

    n = int.Parse(input[0]);
    c = char.Parse(input[1]);

    string s = Console.ReadLine();

    int start = 0;
    int end = n - 1;

    int count = 0;

    if(n == 1)
    {
        Console.WriteLine(0);
        continue;
    }

    while (start < end)
    {
        if (s[start] == c && s[end] != c || s[start] != c && s[end] == c)
        {
            count++;
        }
        else if (s[start] != s[end])
        {
            count += 2;
        }

        start++;
        end--;
    }

    Console.WriteLine(count);
}