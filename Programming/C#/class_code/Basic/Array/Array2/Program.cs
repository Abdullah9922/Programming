using System.Xml.Linq;

class Test
{
    public static void Main(string[] args)
    {
        string[] names = { "Anisul", "Nusrat", "Alex", "Sathi" };

        for (int index = 0; index < names.Length; index++)
        {
            Console.WriteLine(names[index]);
        }

        Console.WriteLine();
        Console.WriteLine();

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}