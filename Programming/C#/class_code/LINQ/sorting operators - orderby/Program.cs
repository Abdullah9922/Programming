
public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}


public class Myclass
{

    public static void Main(string[] args)
    {
        int[] numbers = { 5, 7, 4, 6, 3, 2, 1, 9 };

        var sortedNumbers = numbers.OrderBy(num => num);
        Console.Write("Order by asscending: ");
        foreach (var n in  sortedNumbers)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();


        var sortedNumbersDesc = numbers.OrderByDescending(num => num);
        Console.Write("Order by Descending: ");
        foreach (var n in sortedNumbersDesc)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine();


        List<Person> list = new List<Person>()
        {
            new Person {Name = "Ishyaq Ahmed", Age = 24 },
            new Person {Name = "Al Shariya", Age = 26 },
            new Person {Name = "Subbir Hassan", Age = 22 },
            new Person {Name = "Faruk", Age = 25 },
            new Person {Name = "Faruk", Age = 20 },
        };


        var sortedPeople = list.OrderBy(p => p.Age).ThenBy(p => p.Name);
        Console.Write("Order by Descending: ");
        foreach (var n in sortedPeople)
        {
            Console.WriteLine(n.Name + " " + n.Age + " ");
        }
        Console.WriteLine();
        
    }
}