

public class Person
{
    public string? Name { get; set; }
    public int age { get; set; }

    public string? BloadGroup { get; set; }
}

public class Myclass
{

    public static void Main(string[] args)
    {

        int[] numbers = { 1, 2, 3, 4, 5, 6, };
        var squareNumbers = numbers.Select(num => num * num);

        Console.Write("Square numbers are: ");
        foreach(var number in squareNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();


        List<Person> people = new List<Person>()
        {
            new Person { Name="Arik", age = 23, BloadGroup = "AB+" },
            new Person { Name="Asik", age = 24, BloadGroup = "B+" },
            new Person { Name="Asif", age = 21, BloadGroup = "O+" },
            new Person { Name="Arif", age = 27, BloadGroup = "A-" },
            new Person { Name="Atik", age = 28, BloadGroup = "AB-" },
        };

        var names = people.Select(p => (p.Name,p.BloadGroup));
        Console.Write("Name of people: ");
        foreach (var n in names)
        {
            Console.WriteLine($"{n.Name} {n.BloadGroup}");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        // selecet many 
        List<List<int>> nestedLists = new List<List<int>>
        {
            new List<int> {1,2,3 },
            new List<int> {4,5 },
            new List<int> {6,7,8 },
            new List<int> {9},

        };


        var flattedList = nestedLists.SelectMany(l => l);
        Console.Write("flattedList: ");
        foreach (var n in flattedList)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
    }
}
