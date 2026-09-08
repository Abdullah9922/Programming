
using System.Text;

int tc = int.Parse(Console.ReadLine());

int n,k;
while (tc-- > 0)
{
    string[] input = Console.ReadLine().Split();
    n = int.Parse(input[0]);
    k = int.Parse(input[1]);

    string s = Console.ReadLine();

    int ans = 0;
    for(int i=0; i<n; i += k)
    {
        string sub = s.Substring(i, k);
        int count = sub.Count(c => c == '1');
        if (count == sub.Length) ans ++;
    }
    Console.WriteLine(ans);
}
