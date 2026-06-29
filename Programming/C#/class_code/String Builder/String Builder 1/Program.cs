// strings are immuable. akber create korale change kora jabe na

using System.Diagnostics;
using System.Text;

public class Program
{
    static void Main(string[] args)
    {
        string s1 = "Adil";
        Stopwatch sw = new Stopwatch();

        sw.Start();
        for(int i=0; i< 100000; i++)
        {
            s1 = s1 + i;
        }
        sw.Stop();

        StringBuilder sb = new StringBuilder("hello");
        Stopwatch sw2 = new Stopwatch();

        sw2.Start();
        for (int i = 0; i < 100000; i++)
        {
            sb.Append(i);
        }
        sw2.Start();


        Console.WriteLine("Time taken by string: " + sw.ElapsedMilliseconds);
        Console.WriteLine("Time taken by string builder: " + sw2.ElapsedMilliseconds);
        Console.ReadKey();
    }
}
