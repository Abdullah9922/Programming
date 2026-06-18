using System.ComponentModel;

try
{
    // creating array
    Console.Write($"How many element you want: ");
    int size = int.Parse(Console.ReadLine());
    int[] numbers = new int[size];


    for(int i = 0; i<size; i++)
    {
        Console.WriteLine($"Enter element {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }


    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{numbers[i]}");
        
    }

    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine("Length of the array: " + numbers.Length);
    Console.WriteLine("Rank of the array: " + numbers.Rank);
    Console.WriteLine("Max element of the array: " + numbers.Max());
    Console.WriteLine("Min element of the array: " + numbers.Min());
    Console.WriteLine("Sum element of the array: " + numbers.Sum());
    Console.WriteLine("Avg element of the array: " + numbers.Average());

    //Sort
    Array.Sort(numbers);
    foreach (int n in numbers)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();

    //Reverse
    Array.Reverse(numbers);
    foreach (int n in numbers)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();


    // IndexOf
    int index = Array.IndexOf(numbers, 5);
    Console.WriteLine("Index is: " + index);

    // exist
    bool exists = Array.Exists(numbers, num => num == 6);
    Console.WriteLine("Exists or not: " + exists);


    // Copy
    int[] copy_arr = new int[numbers.Length];
    Array.Copy(numbers, copy_arr, numbers.Length);

    foreach (int n in numbers)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();


    // clear
    Array.Clear(copy_arr);
    foreach (int n in copy_arr)
    {
        Console.Write(n + " ");
    }
    Console.WriteLine();


    Console.ReadKey();
}

catch (Exception ex)
{
    Console.WriteLine($"An error occured: {ex.Message}");
}