using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        int tc = int.Parse(Console.ReadLine());

        string s;
        while (tc-- > 0)
        {
            
            s = Console.ReadLine();

            int index0 = s.IndexOf("0");
            s = s.Remove(index0,1);

            int index1 = s.IndexOf("1");
            s = s.Remove(index1,1);

            Console.WriteLine(s);
        }
    }
}