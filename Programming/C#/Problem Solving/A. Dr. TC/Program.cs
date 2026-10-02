
using System.Text;

int tc = int.Parse(Console.ReadLine());

int n;
while (tc-- > 0)
{
    n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    StringBuilder ans = new StringBuilder();
    StringBuilder temp = new StringBuilder();

    for(int i = 0; i < n; i++)
    {
        temp.Append(s);
        if (temp[i] == '1') temp[i] = '0';
        else temp[i] = '1';
        ans.Append(temp);
        temp.Clear();
    }

    int count = 0;
    for(int i = 0; i < ans.Length; i++)
    {
        if (ans[i] == '1' ) count++;
    }
    Console.WriteLine(count);
}