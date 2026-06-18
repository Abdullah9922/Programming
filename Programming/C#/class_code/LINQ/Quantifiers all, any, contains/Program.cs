
public class Person
{
    public string? Name { get; set; }
    public int Age { get; set; }
}


public class Myclass
{

    public static void Main(string[] args)
    {
        List<Person> list = new List<Person>()
        {
            new Person {Name = "Ishyaq Ahmed", Age = 24 },
            new Person {Name = "Al Shariya", Age = 26 },
            new Person {Name = "Subbir Hassan", Age = 22 },
            new Person {Name = "Faruk", Age = 78 },
            new Person {Name = "ROky", Age = 16 },
        };


        bool allAdalt = list.All(p => p.Age >= 18);
        Console.WriteLine("Are all people adult? -> " + allAdalt);

        bool anyTeenager = list.Any(p => p.Age < 20);
        Console.WriteLine("Is there any teenager? -> " + anyTeenager);

        // contains
        bool containsHassan = list.Select(p => p.Name).Contains("Faruk");
        Console.WriteLine("Is there any Hassan? -> " + containsHassan);

        Console.ReadKey();
    }
}