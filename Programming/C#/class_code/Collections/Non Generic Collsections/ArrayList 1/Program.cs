using System.Collections;

public class Test
{
    public static void Main(string[] args)
    {
        ArrayList myList = new ArrayList();
        myList.Add(1);
        myList.Add("Korim");
        myList.Add(3.75);


        foreach(object obj in myList)
        {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
        

        myList.Insert(2, 25);

        

        myList.Remove(25); // myList.RemoveAt(2); 2 -> Index number
        foreach (object obj in myList)
        {
            Console.Write(obj + " ");
        }
        Console.WriteLine();

        

        Console.ReadKey();
    }
}