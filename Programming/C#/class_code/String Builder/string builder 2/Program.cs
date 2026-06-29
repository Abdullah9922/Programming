
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder("Adil ");

        sb.Append("Ansari");
        Console.WriteLine(sb);

        sb.Append("MCS");
        Console.WriteLine(sb);
        Console.WriteLine();

        StringBuilder sb2 = new StringBuilder();

        sb2.AppendFormat("{0:c}", 25);
        Console.WriteLine(sb2);
        Console.WriteLine();

        sb2.AppendFormat("{0:N}", 25);
        Console.WriteLine(sb2);
        Console.WriteLine();

        sb2.AppendFormat("{0:X}", 25);
        Console.WriteLine(sb2);
        Console.WriteLine();


        sb2.Insert(6, "  ");
        Console.WriteLine(sb2);

        sb2.Insert(13, "  ");
        Console.WriteLine(sb2);


        Console.ReadKey();
    }
}
