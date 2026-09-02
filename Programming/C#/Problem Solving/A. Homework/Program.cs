
using System.Text;

int tc = int.Parse(Console.ReadLine());

int n, m;
StringBuilder a = new StringBuilder();
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    a = new StringBuilder(Console.ReadLine());

    m = int.Parse(Console.ReadLine());
    string b = Console.ReadLine();
    string c = Console.ReadLine();

    for(int i = 0; i < m; i++)
    {
        if (c[i] == 'V') a.Insert(0, b[i]);
        else a.Append(b[i]);
    }

    Console.WriteLine(a);
}