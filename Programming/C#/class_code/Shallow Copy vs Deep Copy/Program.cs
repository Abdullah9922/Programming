// shallow copy vs deep copy
public class MyClass
{
    public static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 3, 4, 5 };

        Console.WriteLine($"originalArray berfore modification: ");
        PrintArray(originalArray);

        int[] shalloWCopy = originalArray; // heap ar mordha je khane data ase oi khane point korse ae 2ta array

        Console.WriteLine($"ShallowArray berfore modification: ");
        PrintArray(shalloWCopy);


        shalloWCopy[0] = 99;
        Console.WriteLine($"originalArray After modification: ");
        PrintArray(originalArray);
        Console.WriteLine($"ShallowArray After modification: ");
        PrintArray(shalloWCopy);


        // Deep copy
        int[] originalArray2 = { 1, 2, 3, 4, 5 };
        int[] deepCopy = new int[originalArray2.Length];
        Array.Copy(originalArray2, deepCopy, originalArray2.Length);

        Console.WriteLine($"originalArray before modification: ");
        PrintArray(originalArray2);
        Console.WriteLine($"ShallowArray before modification: ");
        PrintArray(deepCopy);

        deepCopy[0] = 88;
        Console.WriteLine($"originalArray After modification: ");
        PrintArray(originalArray2);
        Console.WriteLine($"ShallowArray After modification: ");
        PrintArray(deepCopy);

    }


    public static void PrintArray(int[] numbers)
    {
        foreach (var item in numbers)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}